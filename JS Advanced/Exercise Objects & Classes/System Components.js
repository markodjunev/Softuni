function solve(input) {
    let result = {};

    for (const item of input) {
        let [system, component, subcomponent] = item.split(' | ');

        if (!result.hasOwnProperty(system)) {
            result[system] = {};
        }

        if (!result[system].hasOwnProperty(component)) {
            result[system][component] = [];
        }

        result[system][component].push(subcomponent);
    }

    Object.entries(result).sort((a, b) => {
        return Object.keys(b[1]).length - Object.keys(a[1]).length || a[0].localeCompare(b[0]);
    }).forEach(([system, component]) => {
        console.log(system);
        Object.entries(component)
            .sort((a, b) => b[1].length - a[1].length)
            .forEach(([name, sub]) => {
                console.log(`|||${name}`);
                sub.forEach(c => {
                    console.log('||||||' + c);
                })
            });
    });
}

solve(['SULS | Main Site | Home Page',
    'SULS | Main Site | Login Page',
    'SULS | Main Site | Register Page',
    'SULS | Judge Site | Login Page',
    'SULS | Judge Site | Submittion Page',
    'Lambda | CoreA | A23',
    'SULS | Digital Site | Login Page',
    'Lambda | CoreB | B24',
    'Lambda | CoreA | A24',
    'Lambda | CoreA | A25',
    'Lambda | CoreC | C4',
    'Indice | Session | Default Storage',
    'Indice | Session | Default Security']
);