namespace TeisterMask.DataProcessor
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Text;
    using System.Xml.Serialization;
    using AutoMapper;
    using TeisterMask.Data;
    using TeisterMask.Data.Models;
    using TeisterMask.Data.Models.Enums;
    using TeisterMask.DataProcessor.ImportDto;
    using Microsoft.EntityFrameworkCore.Internal;
    using Newtonsoft.Json;

    using ValidationContext = System.ComponentModel.DataAnnotations.ValidationContext;

    using Data;

    public class Deserializer
    {
        private const string ErrorMessage = "Invalid data!";

        private const string SuccessfullyImportedProject
            = "Successfully imported project - {0} with {1} tasks.";

        private const string SuccessfullyImportedEmployee
            = "Successfully imported employee - {0} with {1} tasks.";

        public static string ImportProjects(TeisterMaskContext context, string xmlString)
        {
            var serializer = new XmlSerializer(typeof(ImportProjectDto[]), new XmlRootAttribute("Projects"));
            var projectsDto = (ImportProjectDto[])serializer.Deserialize(new StringReader(xmlString));

            var sb = new StringBuilder();

            foreach (var dto in projectsDto)
            {
                if (IsValid(dto))
                {
                    var project = new Project 
                    {
                        Name = dto.Name,
                        OpenDate = DateTime.ParseExact(dto.OpenDate, "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    };

                    if (dto.DueDate == "" || dto.DueDate == null)
                        project.DueDate = null; 

                    else
                        project.DueDate = DateTime.ParseExact(dto.DueDate, "dd/MM/yyyy", CultureInfo.InvariantCulture);

                    var tasks = new List<Task>();

                    foreach (var taskDto in dto.Tasks)
                    {
                        if (IsValid(taskDto))
                        {
                            var task = new Task
                            {
                                ProjectId = project.Id,
                                Name = taskDto.Name,
                                OpenDate = DateTime.ParseExact(taskDto.OpenDate, "dd/MM/yyyy", CultureInfo.InvariantCulture),
                                DueDate = DateTime.ParseExact(taskDto.DueDate, "dd/MM/yyyy", CultureInfo.InvariantCulture),
                                ExecutionType = Enum.Parse<ExecutionType>(taskDto.ExecutionType),
                                LabelType = Enum.Parse<LabelType>(taskDto.LabelType)
                            };

                            if (project.DueDate != null)
                            {
                                if (task.OpenDate < project.OpenDate ||task.DueDate > project.DueDate)
                                    sb.AppendLine(ErrorMessage);
                                else
                                    tasks.Add(task);
                            }
                            else
                            {
                                if (task.OpenDate < project.OpenDate)
                                    sb.AppendLine(ErrorMessage);
                                else
                                    tasks.Add(task);
                            }
                        }
                        else
                            sb.AppendLine(ErrorMessage);
                    }

                    project.Tasks = tasks;
                    context.Projects.Add(project);
                    context.SaveChanges();
                    sb.AppendLine(string.Format(SuccessfullyImportedProject, project.Name, project.Tasks.Count));
                }
                else
                    sb.AppendLine(ErrorMessage);

            }

            return sb.ToString().TrimEnd();          
        }

        public static string ImportEmployees(TeisterMaskContext context, string jsonString)
        {
            var employeesDto = JsonConvert.DeserializeObject<ImportEmployeeDto[]>(jsonString);
            var sb = new StringBuilder();

            foreach (var dto in employeesDto)
            {
                if (IsValid(dto))
                {
                    var employee = new Employee
                    {
                        Username = dto.Username,
                        Email = dto.Email,
                        Phone = dto.Phone,
                    };

                    var employeeTasks = new List<EmployeeTask>();

                    foreach (var taskId in dto.Tasks)
                    {
                        var task = context.Tasks.FirstOrDefault(t => t.Id == taskId);

                        if (task == null)
                            sb.AppendLine(ErrorMessage);

                        else
                        {
                            employeeTasks.Add(new EmployeeTask
                            {
                                Employee = employee,
                                TaskId = task.Id
                            });
                        }
                    }

                    employee.EmployeesTasks = employeeTasks;

                    context.Employees.Add(employee);

                    sb.AppendLine(string.Format(SuccessfullyImportedEmployee,
                        employee.Username,
                        employee.EmployeesTasks.Count));
                }
                else
                    sb.AppendLine(ErrorMessage);

            }
            context.SaveChanges();
            return sb.ToString().TrimEnd();
        }
     
        private static bool IsValid(object dto)
        {
            var validationContext = new ValidationContext(dto);
            var validationResult = new List<ValidationResult>();

            return Validator.TryValidateObject(dto, validationContext, validationResult, true);
        }
    }
}