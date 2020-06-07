function solve() {
    let menu = document.querySelector('#selectMenuTo');

    const binary = document.createElement('option');
    binary.value = 'binary';
    binary.textContent = 'Binary';

    const hexadecimal = document.createElement('option');
    hexadecimal.value = 'hexadecimal';
    hexadecimal.textContent = 'Hexadecimal';

    menu.appendChild(binary);
    menu.appendChild(hexadecimal);

    const map = {
        'binary': (num) => num.toString(2),
        'hexadecimal': (num) => num.toString(16).toUpperCase()
    };

    const button = document.querySelector('button');

    button.addEventListener('click', function () {
        const number = Number(document.querySelector('#input').value);
        const menuValue = menu.value;

        document.querySelector('#result').value = map[menuValue](number);
    });
}