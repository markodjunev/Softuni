function solve(num){
    const numberAsText = num.toString();
    let sum = 0;
    let areSame = true;

    var curSymb = numberAsText[0];

    for(let i = 0; i < numberAsText.length; i++){
        if(curSymb !== numberAsText[i]){
            areSame = false;
        }
        sum += Number(numberAsText[i]);
    }


    console.log(areSame);
    console.log(sum);
}