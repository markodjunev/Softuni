function solve() {
    const inputName = document.querySelector('#name');
    const inputDesc = document.querySelector('#description');
    const inputImageUrl = document.querySelector('#imageUrl');
    const inputGenre = document.querySelector('#genre');

    let objToEdit = undefined;
    //const movies = document.querySelector('#movies');
    let addBtn = document.querySelector('#addBtn');
    /*const editBtns = document.querySelectorAll('#editBtn');
    const deleteBtns = document.querySelectorAll('#deleteBtn');

    addBtn.addEventListener('click', addMovie);

    [...document.querySelectorAll('#deleteBtn')].forEach(deleteBtn => {
        deleteBtn.addEventListener('click', deleteMovie);
    });

    for (const deleteBtn of deleteBtns) {
        deleteBtn.addEventListener('click', deleteMovie);
    }*/

    const btns = document.querySelectorAll('button').forEach(b => {
        b.addEventListener('click', operation);
    });

    function operation(e) {
        if (e.target.textContent === 'Add movie') {
            addMovie(e);
        } else if (e.target.textContent === 'Delete') {
            deleteMovie(e);
        } else if (e.target.textContent === 'Edit') {
            editMovie(e);
        } else if (e.target.textContent === 'Edit movie') {
            edit(e);
        }
    }

    function addMovie(e) {
        e.preventDefault();
        const movieName = inputName.value.trim();
        const movieDesc = inputDesc.value.trim();
        const movieImageUrl = inputImageUrl.value.trim();
        const movieGenre = inputGenre.value.trim();

        if (movieName.length > 0 && movieDesc.length > 0 && movieImageUrl.length > 0 && movieGenre.length > 0) {
            const movie = { name: movieName, description: movieDesc, imageUrl: movieImageUrl, genre: movieGenre };

            const img = document.createElement("img");
            img.classList.add('card-img-top');
            img.src = movie.imageUrl;
            img.setAttribute('width', '304');
            img.setAttribute('height', '236');

            const cardTitle = el('h5', movie.name, { className: 'card-title' });
            const cardSubTitle = el('h6', movie.genre, { className: 'card-subtitle' });
            cardSubTitle.classList.add('mb-2');
            cardSubTitle.classList.add('text-muted');
            const cardText = el('p', movie.description, { className: 'card-text' });
            const editB = el('a', 'Edit', { className: 'btn btn-primary' });
            editB.setAttribute('id', 'editBtn');
            editB.setAttribute('href', '#');
            const deleteB = el('a', 'Delete', { className: 'btn btn-danger' });
            deleteB.setAttribute('id', 'deleteBtn');
            deleteB.setAttribute('href', '#');

            deleteB.addEventListener('click', deleteMovie);
            editB.addEventListener('click', editMovie);

            const divEditBtn = el('div', editB);
            const divDeleteBtn = el('div', deleteB);
            const buttons = el('div', [divEditBtn, divDeleteBtn], { className: 'd-flex' });
            buttons.classList.add('justify-content-between');

            const cardBody = el('div', [cardTitle, cardSubTitle, cardText, buttons], { className: 'card-body' });

            const card = el('div', [img, cardBody], { className: 'card' });
            card.style.width = '18rem';

            movies.appendChild(card);

            clearValues();
        }
    }

    function deleteMovie(e) {
        const movieToDelete = e.target.parentElement.parentElement.parentElement.parentElement;
        movies.removeChild(movieToDelete);
        clearValues();
        objToEdit = undefined;
        addBtn.textContent = 'Add movie';
        addBtn.classList.remove('btn-success');
        addBtn.classList.add('btn-primary');
    }

    function edit(e) {
        e.preventDefault();
        const movieName = inputName.value.trim();
        const movieDesc = inputDesc.value.trim();
        const movieImageUrl = inputImageUrl.value.trim();
        const movieGenre = inputGenre.value.trim();

        if (movieName.length > 0 && movieDesc.length > 0 && movieImageUrl.length > 0 && movieGenre.length > 0) {
            console.log(objToEdit);
            objToEdit.children[0].attributes.src.nodeValue = movieImageUrl;
            objToEdit.children[1].children[0].textContent = movieName;
            objToEdit.children[1].children[1].textContent = movieGenre;
            objToEdit.children[1].children[2].textContent = movieDesc;

            objToEdit = undefined;
            changeAddBtn(e.target);
            clearValues();
        }
    }

    function editMovie(e) {
        const movieToEdit = e.target.parentElement.parentElement.parentElement.parentElement;
        objToEdit = movieToEdit;
        console.log(objToEdit);
        const parent = e.target.parentElement.parentElement.parentElement;
        changeAddBtn(e.target)
        inputName.value = parent.children[0].textContent;
        inputDesc.value = parent.children[2].textContent;
        inputImageUrl.value = parent.previousElementSibling.attributes.src.nodeValue;
        inputGenre.value = parent.children[1].textContent;
    }

    function changeAddBtn(target) {
        if (target.attributes.id.nodeValue === 'editBtn') {
            addBtn.textContent = 'Edit movie';
            addBtn.classList.remove('btn-primary');
            addBtn.classList.add('btn-success');
        } else if (target.attributes.id.nodeValue === 'addBtn') {
            addBtn.textContent = 'Add movie';
            addBtn.classList.remove('btn-success');
            addBtn.classList.add('btn-primary');
        }
    }

    function el(type, content, attributes) {
        const result = document.createElement(type);

        if (attributes !== undefined) {
            Object.assign(result, attributes);
        }

        if (Array.isArray(content)) {
            content.forEach(append);
        } else {
            append(content);
        }

        function append(node) {
            if (typeof node === 'string') {
                node = document.createTextNode(node);
            }
            result.appendChild(node);
        }

        return result;
    }

    function clearValues() {
        inputName.value = '';
        inputDesc.value = '';
        inputImageUrl.value = '';
        inputGenre.value = 'Comedy';
    }
}