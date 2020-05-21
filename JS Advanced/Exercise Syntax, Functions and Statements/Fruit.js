function solve(fruit, weight, pricePerKg){
    let price = ((weight / 100) * pricePerKg) / 10;
    let weightInKg = weight / 1000;

    console.log(`I need $${price.toFixed(2)} to buy ${weightInKg.toFixed(2)} kilograms ${fruit}.`)
}