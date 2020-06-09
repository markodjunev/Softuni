function focus() {
    let inputs = document.querySelectorAll('input');

    Array.from(inputs).forEach(input => {
        input.addEventListener('focus', function(e) {
            let currentTarget = e.target.parentElement;
            currentTarget.classList.add('focused');
        });

        input.addEventListener('blur', function(e) {
            let currentTarget = e.target.parentElement;
            currentTarget.classList.remove('focused');
        });
    });
}