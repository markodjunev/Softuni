function notify(message) {
    let div = document.querySelector('#notification');
    div.textContent = message;
    div.style.display = 'block';

    setTimeout(() => {
        div.style.display = 'none';
    }, 2000)
}