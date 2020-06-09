function deleteByEmail() {
    let input = document.getElementsByTagName('input')[0].value;
    let emails = Array.from(document.querySelectorAll('#customers td:last-child'));
    let result = document.getElementById('result');

    result.textContent = '';

    let td = emails.find(function(td) {return td.innerText === input});
    if(!td){
        result.textContent = 'Not found.';
        document.getElementsByTagName('input')[0].value = '';
        return;
    }
    
    result.textContent = 'Deleted.';
    td.parentElement.remove();
}