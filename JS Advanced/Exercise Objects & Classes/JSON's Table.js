function solve(data) {
    const arr = data.map(x => JSON.parse(x));
    let result = '<table>';
    result = arr.reduce((acc, curr) => {
        const value = Object.values(curr);
        return acc += '\n\t<tr>\n\t\t<td>' + value.join('</td>\n\t\t<td>') + '</td>\n\t</tr>';
    }, result);
    return result += '\n</table>';
}

console.log(solve(['{"name":"Pesho","position":"Promenliva","salary":100000}',
'{"name":"Teo","position":"Lecturer","salary":1000}',
'{"name":"Georgi","position":"Lecturer","salary":1000}']
));