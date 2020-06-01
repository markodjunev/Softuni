function solve(input, param) {
    let result = [];

    class Ticket {
        constructor(destination, price, status) {
            this.destination = destination;
            this.price = +price;
            this.status = status;
        }
    }

    for (const item of input) {
        let [destination, price, status] = item.split('|');
        let ticket = new Ticket(destination, price, status);
        result.push(ticket)
    }

    const comparator = {
        destination: (a, b) => a.destination.localeCompare(b.destination),
        price: (a, b) => Number(a.price) - Number(b.price),
        status: (a, b) => a.status.localeCompare(b.status)
    };

    return result.sort(comparator[param]);
}

console.log(solve(['Philadelphia|94.20|available',
    'New York City|95.99|available',
    'New York City|95.99|sold',
    'Boston|126.20|departed'],
    'destination'
));