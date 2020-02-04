namespace TeisterMask.DataProcessor
{
    using System;
    using Data;
    using System.Linq;
    using Formatting = Newtonsoft.Json.Formatting;
    using Newtonsoft.Json;
    using System.Globalization;
    using System.Xml.Serialization;
    using System.Text;
    using System.IO;
    using TeisterMask.DataProcessor.ExportDto;
    using System.Xml;

    public class Serializer
    {
        public static string ExportProjectWithTheirTasks(TeisterMaskContext context)
        {
            var projectsWithTheirTasks = context.Projects
                .Where(p => p.Tasks.Any())
                .OrderByDescending(p => p.Tasks.Count)
                .ThenBy(p => p.Name)
                .Select(p => new ExportProjectDto
                {
                    TasksCount = p.Tasks.Count,
                    ProjectName = p.Name,
                    HasEndDate = HasProjectEndDate(p.DueDate),
                    Tasks = p.Tasks
                        .Select(t => new ExportProjectTaskDto
                        {
                            Name = t.Name,
                            Label = t.LabelType.ToString()
                        })
                        .OrderBy(t => t.Name)
                        .ToArray()
                })
                .ToArray();

            var rootAttribute = new XmlRootAttribute("Projects");
            var xmlSerializer = new XmlSerializer(typeof(ExportProjectDto[]), rootAttribute);

            var sb = new StringBuilder();

            var stringWriter = new StringWriter(sb);

            var namespaces = new XmlSerializerNamespaces(new[] { XmlQualifiedName.Empty });
            xmlSerializer.Serialize(stringWriter, projectsWithTheirTasks, namespaces);

            return sb.ToString().TrimEnd();
        }

        public static string ExportMostBusiestEmployees(TeisterMaskContext context, DateTime date)
        {

            var employees = context.Employees
               .Where(e => e.EmployeesTasks.Any(t => t.Task.OpenDate >= date))
               .Select(e => new
               {
                   Username = e.Username,
                   Tasks = e.EmployeesTasks
                     .Where(t => t.Task.OpenDate >= date)
                     .OrderByDescending(t => t.Task.DueDate)
                     .ThenBy(t => t.Task.Name)
                     .Select(t => new
                     {
                         TaskName = t.Task.Name,
                         OpenDate = t.Task.OpenDate.ToString("d", CultureInfo.InvariantCulture),
                         DueDate = t.Task.DueDate.ToString("d", CultureInfo.InvariantCulture),
                         LabelType = t.Task.LabelType.ToString(),
                         ExecutionType = t.Task.ExecutionType.ToString()
                     })
                     .ToArray()
               })
               .ToArray()
               .OrderByDescending(e => e.Tasks.Length)
               .ThenBy(e => e.Username)
               .Take(10)
               .ToArray();

            var employeesJson = JsonConvert.SerializeObject(employees, Formatting.Indented);

            return employeesJson;
        }

        private static string HasProjectEndDate(DateTime? dueDate)
        {
            if (dueDate == null)
                return "No";

            else
                return "Yes";
        }
    }
}