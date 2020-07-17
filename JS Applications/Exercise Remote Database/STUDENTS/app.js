import el from './dom.js';
import * as api from './data.js';

window.addEventListener('load', async () => {
    const tbody = document.querySelector('#results > tbody');

    async function loadStudents() {
        tbody.innerHTML = '<tr><td colspan="5">Loading...</td><tr>';

        try {
            const students = await api.getStudents();
            tbody.innerHTML = '';

            students.sort((a, b) => {
                return b.grade - a.grade;
            });

            let id = 0;

            students.forEach(student => {
                const studentEl = createStudentElement(student, ++id);
                tbody.appendChild(studentEl);
            });
        } catch (error) {
            alert(`Error: ${error.message}`);
        }
    }

    function createStudentElement(student, id) {
        return el('tr', [
            el('td', id),
            el('td', student.firstName),
            el('td', student.lastName),
            el('td', student.facultyNumber),
            el('td', student.grade.toFixed(2)),
        ]);
    }

    await loadStudents();
});