function solve(input, criteria){
    let propName, propValue;
    const isNotAll = criteria !== 'all';
    if(isNotAll){
        [propName, propValue] = criteria.split('-');
    }

    let data;
    try {
        data = JSON.parse(input);
    } catch {
        data = [];
    }

    return data.filter(function(emp) {
        return isNotAll ? emp[propName] === propValue : true;
    }).forEach((item, i) => {
        console.log(`${i}. ${item.first_name} ${item.last_name} - ${item.email}`);
    });
}

let input = `[{
    "id": "1",
    "first_name": "Ardine",
    "last_name": "Bassam",
    "email": "abassam0@cnn.com",
    "gender": "Female"
  }, {
    "id": "2",
    "first_name": "Kizzee",
    "last_name": "Jost",
    "email": "kjost1@forbes.com",
    "gender": "Female"
  },  
{
    "id": "3",
    "first_name": "Evanne",
    "last_name": "Maldin",
    "email": "emaldin2@hostgator.com",
    "gender": "Male"
  }]`;

  console.log(solve(input, 'gender-Female'));