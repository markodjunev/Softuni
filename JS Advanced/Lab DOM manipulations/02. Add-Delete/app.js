function addItem() {
    let items = document.querySelector('#items');
    let input = document.querySelector('#newText').value;

    if(!input){
        return;
    }
    
    let li = document.createElement('li');

    let a = document.createElement('a');
    let textDelete = document.createTextNode('[Delete]');
    a.appendChild(textDelete);
    a.href = '#';

    a.addEventListener('click', function (e) {
        e.target.parentElement.remove();
    });

    li.textContent = input;
    li.appendChild(a);
    items.appendChild(li);

    document.querySelector('#newText').value = '';
}