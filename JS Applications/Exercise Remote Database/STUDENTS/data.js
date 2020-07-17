const appId = 'C7A01BF4-DF09-62EB-FFA1-1FA6D2B45600';
const restApiKey = 'E3E731EA-7573-4392-89EF-9967D4D64760';

function host(endpoint) {
    return `https://api.backendless.com/${appId}/${restApiKey}/data/${endpoint}`;
}

export async function getStudents() {
    const response = await fetch(host('Students'));
    const data = await response.json();
    return data;
}

export async function createStudent(student) {
    const response = await fetch(host('Students'), {
        method: 'POST',
        body: JSON.stringify(student),
        headers: {
            'Content-Type': 'application/json'
        }
    });

    const data = await response.json();
    return data;
}