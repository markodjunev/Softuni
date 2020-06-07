function growingWord() {
  let word = document.querySelector('#exercise > p');
  let px = 2;
  let colors = {
    'blue' : 'green',
    'green' : 'red',
    'red' : 'blue'
  };

  if(!word.hasAttribute('style')){
    word.setAttribute('style', `color:blue; font-size: ${px}px`)
  }
  else{
    let curPx = word.style['font-size'];
    px = curPx.substr(0, curPx.length - 2) * 2;
    let curColor = word.style.color;
    word.setAttribute('style', `color:${colors[curColor]}; font-size: ${px}px`)
  }
}