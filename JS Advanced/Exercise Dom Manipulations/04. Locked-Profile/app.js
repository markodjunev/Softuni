function lockedProfile() {
    const mainDiv = document.querySelector('main');
    mainDiv.addEventListener('click', (e) => {
 
        if (e.target.tagName === 'BUTTON') {
            let user = e.target.previousElementSibling;
            let inputName = user.id.substring(0, user.id.indexOf('H')) + 'Locked';
            const [lockButton, unlockButton] =Array.from(document.getElementsByName(inputName));
 
            if (unlockButton.checked && e.target.textContent == 'Show more') {
                user.style.display = 'block';
                e.target.textContent = 'Hide it';
                e.removeEventListener();
            }
            if (unlockButton.checked && e.target.textContent == 'Hide it') {
                user.style.display = 'none';
                e.target.textContent = 'Show more';
            }
        }
    })
}