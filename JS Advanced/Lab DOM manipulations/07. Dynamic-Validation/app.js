function validate() {
    let input = document.querySelector('#email');
    const regex = /^(([^<>()\[\]\\.,;:\s@"]+(\.[^<>()\[\]\\.,;:\s@"]+)*)|(".+"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/;

    input.addEventListener('change', function (e) {
        if (e.target.value.search(regex) === -1) {
            e.target.classList.add('error');
        } else {
            e.target.classList.remove('error');
        }
    });
}