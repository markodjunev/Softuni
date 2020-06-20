function solve(input) {
    let list = [];

    const operations = {
        'add': (x) => add(x),
        'remove': (x) => remove(x),
        'print': () => console.log(print())
    };

    function add(string) {
        list.push(string);
    }

    function remove(string) {
        list = list.filter(i => i !== string);
    }

    function print() {
        return list.join(',');
    }

    input.forEach(item => {
        const [command, string] = item.split(' ');

        return operations[command](string);
    });
}

solve(['add pesho', 'add george', 'add peter', 'remove peter', 'print']);