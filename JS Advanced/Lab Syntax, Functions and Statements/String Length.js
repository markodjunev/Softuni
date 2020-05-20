function stringLength(word1, word2, word3){
    let totalSum;
    let averageSum;

    let firstWordLength = word1.length;
    let secondWordLength = word2.length;
    let thirdWordLength = word3.length;

    totalSum = firstWordLength + secondWordLength + thirdWordLength;
    averageSum = Math.floor(totalSum / 3);

    console.log(totalSum);
    console.log(averageSum);
}