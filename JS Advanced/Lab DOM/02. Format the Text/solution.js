function solve() {
  let input = document.getElementById('input').innerText.split('. ');
  let output = document.getElementById('output');
  let p = document.createElement('p');

  for (let i = 0; i < input.length; i++) {
    const sentence = input[i];
    if(i % 3 === 0){
      output.appendChild(p);
      p = document.createElement('p');
    }
    p.innerText += sentence;
  }

  output.appendChild(p);
}
