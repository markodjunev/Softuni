function loadRepos() {
   const url = "https://api.github.com/users/testnakov/repos";

   fetch(url)
       .then(response => {
           if (response.status === 200) {
               return response.json();
           }
       })
       .then(response => {
           if (!response) {
               return;
           }

           const outputItem = document.getElementById("res");
           outputItem.textContent = JSON.stringify(response);
       })
}