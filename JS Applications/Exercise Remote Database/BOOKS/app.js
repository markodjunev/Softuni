import el from './dom.js';
import * as api from './data.js';

window.addEventListener('load', () => {
    const table = document.querySelector('table tbody');
    document.querySelector('#loadBooks').addEventListener('click', displayBooks);

    const input = {
        title: document.querySelector('#title'),
        author: document.querySelector('#author'),
        isbn: document.querySelector('#isbn'),
    };

    const createBtn = document.querySelector('form > button');
    createBtn.addEventListener('click', createBook);

    async function createBook(e) {
        e.preventDefault();

        const book = {
            title: input.title.value,
            author: input.author.value,
            isbn: input.isbn.value
        };

        let valid = true
        Object.entries(book).find(([k, v]) => {
            if (v.length === 0) {
                alert(`Book ${v} cannot be empty!`);
                valid = false;
                return true;
            } else {
                return false;
            }
        });

        if (valid === false) {
            return;
        }

        try {
            Object.entries(input).forEach(([k, v]) => v.disabled = true);
            createBtn.disabled = true;
            const created = await api.createBook(book);
            table.appendChild(renderBook(created));
            Object.entries(input).forEach(([k, v]) => v.value = '');

        } catch (err) {
            alert(err);
            console.error(err);
        } finally {
            Object.entries(input).forEach(([k, v]) => v.disabled = false);
            createBtn.disabled = false;
        }
    }

    function displayBooks() {
        table.innerHTML = '<tr><td colspan="4">Loading....</td></tr>';
        const books = await api.getBooks();
        books.sort((a, b) => a.author.localeCompare(b.author))
            .forEach(b => b.appendChild(renderBook(b)));

    }

    function renderBook(book) {
        const deleteBtn = el('button', 'DELETE');
        deleteBtn.addEventListener('click', deleteBook);

        const editBtn = el('button', 'EDIT');
        editBtn.addEventListener('click', editBook);
        const element = el('tr', [
            el('td', book.title),
            el('td', book.author),
            el('td', book.isbn),
            el('td', [
                editBtn,
                deleteBtn
            ]),
        ]);

        async function deleteBook() {
            try {
                api.deleteBook(book.objectId);
                element.remove;
            } catch (err) {
                alert(err);
                console.error(err);
            }
        }

        function editBook(e) {
            const confirmBtn = el('button', 'Confirm');
            confirmBtn.addEventListener('click', )
            const cancelBtn = el('button', 'Cancel');
            cancelBtn.addEventListener('click', () => {
                table.replaceChild(element, editor);
            });
            const edit = {
                title: el('input', null, { type: 'text', value: book.title }),
                author: el('input', null, { type: 'text', value: author.title }),
                isbn: el('input', null, { type: 'text', value: isbn.title })
            }

            const editor = el('tr', [
                el('td', edit.title),
                el('td', edit.author),
                el('td', edit.isbn),
                el('td', [
                    confirmBtn,
                    cancelBtn
                ]),
            ]);

            table.replaceChild(editor, element);
        }

        return element;
    }


})
