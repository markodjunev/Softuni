function solve() {
   document.querySelector('#searchBtn').addEventListener('click', onSearch);

   function onSearch(e){
      let input = document.querySelector('#searchField').value;
      if(input.trim().length > 0){
         const tbody = document.querySelector('tbody');
         [...tbody.querySelectorAll('tr')].forEach(r => {
            r.classList.remove('select');
         });


         [...tbody.querySelectorAll('td')].forEach(d =>{
            if(d.textContent.includes(input)){
               d.parentNode.classList.add('select');
            }
         });
      }

      input.value = '';
   }
}