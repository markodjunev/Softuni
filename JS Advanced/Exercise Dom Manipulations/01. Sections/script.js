function create(words) {
   const divList = [];

   words.forEach(word => {
      const p = document.createElement('p');
      p.textContent = word;
      p.style.display = 'none';
      
      const div = document.createElement('div');
      div.appendChild(p);
      div.addEventListener('click', function(e) {
         const child = e.target.firstChild;
         child.style.display = 'block';
      });

      divList.push(div);
   });

   const content = document.getElementById('content');
   divList.forEach(div => content.appendChild(div));
}