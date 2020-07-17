const appId = 'C7A01BF4-DF09-62EB-FFA1-1FA6D2B45600';
const restApiKey = 'E3E731EA-7573-4392-89EF-9967D4D64760';

function host(endpoint) {
    return `https://api.backendless.com/${appId}/${restApiKey}/data/${endpoint}`;
}

export async function getBooks() {
    const response = await fetch(host('Books'));
    const data = await response.json();
    return data;
}

export async function createBook(book) {
    const response = await fetch(host('Books'), {
        method: 'POST',
        body: JSON.stringify(book),
        headers: {
            'Content-Type': 'application/json'
        }
    });

    const data = await response.json();
    return data;
}

export async function updateBook(book) {
    const id = book.objectId;
    const response = await fetch(host('Books/' + id), {
        method: 'PUT',
        body: JSON.stringify(book),
        headers: {
            'Content-Type': 'application/json'
        }
    });

    const data = await response.json();
    return data;
}

export async function deleteBook(id) {
    const response = await fetch(host('Books/' + id), {
        method: 'DELETE'
    });

    const data = await response.json();
    return data;
}