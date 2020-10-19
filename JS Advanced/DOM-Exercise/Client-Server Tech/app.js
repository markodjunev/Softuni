function solve() {
    const inputName = document.querySelector('#name');
    const inputDesc = document.querySelector('#description');
    const inputImageUrl = document.querySelector('#imageUrl');
    const inputGenre = document.querySelector('#genre');
    
    const movies = document.querySelector('#movies');

    document.querySelector('#addBtn').addEventListener('click', addMovie);

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
            const edinBtn = el('a', 'Edit', { className: 'btn btn-primary' });
            const deleteBtn = el('a', 'Delete', { className: 'btn btn-danger' });
            edinBtn.setAttribute('id', 'editBtn');
            deleteBtn.setAttribute('id', 'deleteBtn');
            edinBtn.setAttribute('href', '#');
            deleteBtn.setAttribute('href', '#');
            const divEditBtn = el('div', edinBtn);
            const divDeleteBtn = el('div', deleteBtn);
            const buttons = el('div', [divEditBtn, divDeleteBtn], { className: 'd-flex' });
            buttons.classList.add('justify-content-between');

            const cardBody = el('div', [cardTitle, cardSubTitle, cardText, buttons], { className: 'card-body' });

            const card = el('div', [img, cardBody], { className: 'card'});
            card.style.width = '18rem';

            movies.appendChild(card);
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
}