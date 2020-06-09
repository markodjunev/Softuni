function addItem() {
    let items = document.querySelector('#items');
    let input = document.querySelector('#newItemText').value;

    let newItem = document.createElement('li');
    newItem.textContent = input;
    items.appendChild(newItem);

    document.querySelector('#newItemText').value = '';
}