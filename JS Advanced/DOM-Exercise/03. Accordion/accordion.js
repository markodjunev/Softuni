function toggle() {
    let el = document.getElementById("extra");

    if(el.style.display === "none"){
        el.style.display = "block";
        document.getElementsByClassName("button")[0].textContent = 'Less';
    } else{
        el.style.display = "none";
        document.getElementsByClassName("button")[0].textContent = 'More';
    }
}