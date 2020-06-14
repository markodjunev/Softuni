function solve(){
   let rows = document.querySelectorAll("tbody > tr");
   Array.from(rows).forEach(x => x.addEventListener("click", changeColor))

   function changeColor(e) {
       let element = e.target.parentElement;

       if (element.style.backgroundColor === "") {
         Array.from(rows).forEach(x => x.style.backgroundColor = "");
         element.style.backgroundColor = "#413f5e";
       } else{
         element.style.backgroundColor = "";
       }
   }
}
