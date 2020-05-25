function solve(arr){
    let number = 1;
    let result = [];

    for (let i = 0; i < arr.length; i++) {
        const command = arr[i];
        
        switch(command){
            case 'add': 
            result.push(number++);
            break;
            case 'remove':
                result.length > 0 ? result.pop(number++) : ++number;
                break;
        }
    }

    result.length === 0 ? console.log('Empty') : print();

    function print(){
        for (let i = 0; i < result.length; i++) {
            const element = result[i];
            
            console.log(element);
        }
    }
}

solve(['add', 
'add', 
'remove', 
'add', 
'add']
);