function solve() {
    const btn = document.getElementById('dropdown');
    const ul = document.querySelector('#dropdown-ul');

    const liList = ul.querySelectorAll('li');
    const box = document.getElementById('box');

    box.style.color = "black"

    Array.from(liList).forEach(x => x.addEventListener("click", onLiClick));
    btn.addEventListener("click", onBtnClick);


    function onLiClick(e) {
        box.style.backgroundColor = e.target.textContent;
    }

    function onBtnClick() {
        if (ul.style.display === "block") {
            ul.style.display = "none";
            box.style.backgroundColor = "black"
            box.style.color = "white";
        } else {
            ul.style.display = "block"
        }
    }
}