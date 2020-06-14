class Company {
    constructor(){
        this.departments = [];
    }

    addEmployee(username, salary, position, department) {
        if (username && salary > 0 && position && department) {
            let foundDepartment = this.departments.find(x => x.name === department);

            if (!foundDepartment) {
                foundDepartment = {
                    name: department,
                    employees: []
                };
                this.departments.push(foundDepartment)
            }

            foundDepartment.employees.push({username, salary, position});

            return `New employee is hired. Name: ${username}. Position: ${position}`;
        }
        throw new Error("Invalid input!");
    }

    bestDepartment() {
        let bestDepartments = this.departments.sort(((a, b) => b.salary - a.salary))
        const bestDepartment = bestDepartments[0];

        const sum = bestDepartment.employees.map(x => x.salary).reduce((a, b) => a + b, 0);

        const bestDepartmentAvgSalary = sum / bestDepartment.employees.length;

        const employeesOutput = bestDepartment.employees
            .sort((a, b) => b.salary - a.salary || a.username.localeCompare(b.username))
            .reduce((acc, curr) => {
                return acc += `${curr.username} ${curr.salary} ${curr.position}\n`;
            }, "")
            .trimEnd();

        return `Best Department is: ${bestDepartment.name}\n` +
            `Average salary: ${bestDepartmentAvgSalary.toFixed(2)}\n` +
            employeesOutput;
    }
}

let c = new Company();
c.addEmployee("Stanimir", 2000, "engineer", "Construction");
c.addEmployee("Pesho", 1500, "electrical engineer", "Construction");
c.addEmployee("Slavi", 500, "dyer", "Construction");
c.addEmployee("Stan", 2000, "architect", "Construction");
c.addEmployee("Stanimir", 1200, "digital marketing manager", "Marketing");
c.addEmployee("Pesho", 1000, "graphical designer", "Marketing");
c.addEmployee("Gosho", 1350, "HR", "Human resources");
console.log(c.bestDepartment());
