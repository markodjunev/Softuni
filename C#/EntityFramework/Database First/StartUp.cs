namespace SoftUni
{
    using System;
    using System.Globalization;
    using System.Linq;
    using System.Text;

    using SoftUni.Data;
    using SoftUni.Models;

    public class StartUp
    {
        public static void Main()
        {
           // var context = new SoftUniContext();
           // Console.WriteLine(GetEmployeesByFirstNameStartingWithSa(context));
        }

        public static string GetEmployeesFullInformation(SoftUniContext context)
        {
            var result = new StringBuilder();

            var employees = context.Employees
                .Select(e => new
                {
                    e.EmployeeId,
                    e.FirstName,
                    e.LastName,
                    e.MiddleName,
                    e.JobTitle,
                    e.Salary
                })
                .OrderBy(e => e.EmployeeId)
                .ToList();

            foreach (var employee in employees)
            {
                result.AppendLine($"{employee.FirstName} {employee.LastName} {employee.MiddleName} {employee.JobTitle} {employee.Salary:F2}");
            }

            return result.ToString().TrimEnd();
        }

        public static string GetEmployeesWithSalaryOver50000(SoftUniContext context)
        {
            var sb = new StringBuilder();

            var employees = context.Employees.Select(e => new
            {
                e.FirstName,
                e.Salary
            })
            .Where(e => e.Salary > 50000)
            .OrderBy(e => e.FirstName)
            .ToList();

            foreach (var emp in employees)
            {
                sb.AppendLine($"{emp.FirstName} - {emp.Salary:f2}");
            }

            return sb.ToString().TrimEnd();
        }

        public static string GetEmployeesFromResearchAndDevelopment(SoftUniContext context)
        {
            var employees = context.Employees
                .Select(e => new
                {
                    e.FirstName,
                    e.LastName,
                    DepartmentName = e.Department.Name,
                    e.Salary
                })
                .Where(e => e.DepartmentName == "Research and Development")
                .OrderBy(e => e.Salary)
                .ThenByDescending(e => e.FirstName)
                .ToList();

            var result = new StringBuilder();

            foreach (var emp in employees)
            {
                result.AppendLine($"{emp.FirstName} {emp.LastName} from {emp.DepartmentName} - ${emp.Salary:F2}");
            }

            return result.ToString().TrimEnd();
        }

        public static string AddNewAddressToEmployee(SoftUniContext context)
        {
            var address = new Address
            {
                AddressText = "Vitoshka 15",
                TownId = 4
            };

            var employee = context.Employees
                .FirstOrDefault(e => e.LastName == "Nakov");

            address.Employees.Add(employee);

            employee.Address = address;

            context.SaveChanges();

            var employeesAddresses = context.Employees
                .OrderByDescending(e => e.AddressId)
                .Select(e => e.Address.AddressText)
                .Take(10)
                .ToList();

            var result = new StringBuilder();

            foreach (var addr in employeesAddresses)
            {
                result.AppendLine(addr);
            }

            return result.ToString().TrimEnd();
        }

        public static string GetEmployeesInPeriod(SoftUniContext context)
        {
            var result = new StringBuilder();

            var employees = context.Employees
                .Where(e=> e.EmployeesProjects
                .Any(p=> p.Project.StartDate.Year >= 2001 && p.Project.StartDate.Year <= 2003))
                .Select(e => new 
                {
                    e.FirstName,
                    e.LastName,
                    ManagerFirstName = e.Manager.FirstName,
                    ManagerLastName = e.Manager.LastName,
                    Projects = e.EmployeesProjects
                        .Select(p => p.Project)
                })
                .Take(10)
                .ToList();

            foreach (var emp in employees)
            {
                var employeeName = emp.FirstName + " " + emp.LastName;
                var managerName = emp.ManagerFirstName + " " + emp.ManagerLastName;

                result.AppendLine($"{employeeName} - Manager: {managerName}");

                foreach (var project in emp.Projects)
                {
                    var projectName = project.Name;
                    var startDate = project.StartDate.ToString("M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                    var endDate = project.EndDate == null
                        ? "not finished"
                        : project.EndDate.Value.ToString("M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);

                    result.AppendLine($"--{projectName} - {startDate} - {endDate}");
                }
            }

            return result.ToString().TrimEnd();
        }

        public static string GetAddressesByTown(SoftUniContext context)
        {
            var addresses = context.Addresses
                .Select(a => new
                {
                    a.AddressText,
                    TownName = a.Town.Name,
                    EmployeesCount = a.Employees.Count
                })
                .OrderByDescending(a => a.EmployeesCount)
                .ThenBy(a => a.TownName)
                .ThenBy(a => a.AddressText)
                .ToList();

            var result = new StringBuilder();

            foreach (var address in addresses)
            {
                result.AppendLine($"{address.AddressText}, {address.TownName} - {address.EmployeesCount} employees");
            }

            return result.ToString().TrimEnd();
        }

        public static string GetEmployee147(SoftUniContext context)
        {
            var employee = context.Employees
                .Where(e => e.EmployeeId == 147)
                .Select(e => new
                {
                    e.FirstName,
                    e.LastName,
                    e.JobTitle,
                    ProjectNames = e.EmployeesProjects
                            .Select(p => p.Project.Name)
                            .OrderBy(p => p)
                })
                .FirstOrDefault();

            var result = new StringBuilder();

            result.AppendLine($"{employee.FirstName} {employee.LastName} - {employee.JobTitle}");

            foreach (var project in employee.ProjectNames)
            {
                result.AppendLine(project);
            }

            return result.ToString().TrimEnd();
        }

        public static string GetDepartmentsWithMoreThan5Employees(SoftUniContext context)
        {
            var departments = context.Departments
                .Where(d => d.Employees.Count > 5)
                .OrderBy(d => d.Employees.Count)
                .ThenBy(d => d.Name)
                .Select(d => new
                {
                    d.Name,
                    ManagerFirstName = d.Manager.FirstName,
                    ManagerLastName = d.Manager.LastName,
                    Employees = d.Employees.
                     Select(e => new
                     {
                         e.FirstName,
                         e.LastName,
                         e.JobTitle
                     })
                     .OrderBy(e => e.FirstName)
                     .ThenBy(e => e.LastName)
                })
                .ToList();

            var result = new StringBuilder();

            foreach (var dep in departments)
            {
                result.AppendLine($"{dep.Name} - {dep.ManagerFirstName} {dep.ManagerLastName}");

                foreach (var emp in dep.Employees)
                {
                    result.AppendLine($"{emp.FirstName} {emp.LastName} - {emp.JobTitle}");
                }
            }

            return result.ToString().TrimEnd();
        }

        public static string GetLatestProjects(SoftUniContext context)
        {
            var projects = context.Projects
                .OrderByDescending(p => p.StartDate)
                .Select(p => new
                {
                    p.Name,
                    p.Description,
                    p.StartDate
                })
                .Take(10)
                .OrderBy(p => p.Name)
                .ToList();


            var result = new StringBuilder();

            foreach (var project in projects)
            {
                result.AppendLine(project.Name);
                result.AppendLine(project.Description);
                result.AppendLine(project.StartDate.ToString("M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture));
            }

            return result.ToString().TrimEnd();
        }

        public static string IncreaseSalaries(SoftUniContext context)
        {
            var employees = context.Employees
                    .Where(e => e.Department.Name == "Engineering"
                        || e.Department.Name == "Tool Design"
                        || e.Department.Name == "Marketing"
                        || e.Department.Name == "Information Services")
                    .ToList();

            foreach (var emp in employees)
            {
                emp.Salary += emp.Salary * 0.12M;
            }

            context.SaveChanges();

            var updatedEmployees = context.Employees
                .Where(e => e.Department.Name == "Engineering"
                    || e.Department.Name == "Tool Design"
                    || e.Department.Name == "Marketing"
                    || e.Department.Name == "Information Services")
                .Select(e => new
                {
                    e.FirstName,
                    e.LastName,
                    e.Salary
                })
                .OrderBy(e => e.FirstName)
                .ThenBy(e => e.LastName)
                .ToList();

            var result = new StringBuilder();

            foreach (var emp in updatedEmployees)
            {
                result.AppendLine($"{emp.FirstName} {emp.LastName} (${emp.Salary:F2})");
            }

            return result.ToString().TrimEnd();
        }

        public static string GetEmployeesByFirstNameStartingWithSa(SoftUniContext context)
        {
            var employees = context.Employees
                .Where(e => e.FirstName.StartsWith("Sa"))
                .Select(e => new
                {
                    e.FirstName,
                    e.LastName,
                    e.JobTitle,
                    e.Salary
                })
                .OrderBy(e => e.FirstName)
                .ThenBy(e => e.LastName)
                .ToList();

            var result = new StringBuilder();

            foreach (var emp in employees)
            {                         
                result.AppendLine($"{emp.FirstName} {emp.LastName} - {emp.JobTitle} - (${emp.Salary:F2})");
            }

            return result.ToString().TrimEnd();
        }

        public static string DeleteProjectById(SoftUniContext context)
        {
            var projectToRemove = context.Projects
                .FirstOrDefault(p => p.ProjectId == 2);

            var employeesProjects = context.EmployeesProjects
                .Where(p => p.ProjectId == 2)
                .ToList();

            foreach (var employeeProject in employeesProjects)
            {
                context.EmployeesProjects.Remove(employeeProject);
            }

            context.Projects.Remove(projectToRemove);

            context.SaveChanges();

            var projects = context.Projects
                .Select(p => p.Name)
                .Take(10)
                .ToList();

            var result = new StringBuilder();

            foreach (var name in projects)
            {
                result.AppendLine(name);
            }

            return result.ToString().TrimEnd();
        }

        public static string RemoveTown(SoftUniContext context)
        {
            var addressIdsToRemove = context.Addresses
                .Where(a => a.Town.Name == "Seattle")
                .Select(a => a.AddressId)
                .ToList();

            var employees = context.Employees
                .ToList();

            foreach (var id in addressIdsToRemove)
            {
                foreach (var emp in employees)
                {
                    emp.AddressId = null;
                }
            }

            var addressesToRemove = context.Addresses
                .Where(a => a.Town.Name == "Seattle")
                .ToList();

            foreach (var address in addressesToRemove)
            {
                context.Addresses.Remove(address);
            }

            var townToRemove = context.Towns
                .FirstOrDefault(t => t.Name == "Seattle");

            context.Towns.Remove(townToRemove);

            context.SaveChanges();

            return $"{addressesToRemove.Count} addresses in Seattle were deleted";
        }

    }
}