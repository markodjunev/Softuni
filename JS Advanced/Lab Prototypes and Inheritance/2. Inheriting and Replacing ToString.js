function solve() {
    class Person {
        constructor(name, email) {
            this.name = name;
            this.email = email;
        }

        toString() {
            return `${this.constructor.name} (name: ${this.name}, email: ${this.email})`
        }
    }

    class Teacher extends Person {
        constructor(name, email, subject) {
            super(name, email);
            this.subject = subject;
        }

        toString() {
            let newString = super.toString();
            newString = newString.substr(0, newString.length - 1);

            return newString + `, subject: ${this.subject})`;
        }
    }

    class Student extends Person {

        constructor(name, email, course) {
            super(name, email);
            this.course = course;
        }

        toString() {
            let newString = super.toString();
            newString = newString.substr(0, newString.length - 1);

            return newString + `, course: ${this.course})`;
        }

    }

    return {
        Person,
        Teacher,
        Student
    }

}