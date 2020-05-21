function solve(speedA, area){
    let speed = Number(speedA);
    const motorwaySpeed = Number(130);
    const interstateSpeed  = Number(90);
    const citySpeed = Number(50);
    const residentialSpeed  = Number(20);

    let limitation = 0;

    switch(area){
        case 'motorway': limitation = motorwaySpeed; break;
        case 'interstate': limitation = interstateSpeed; break;
        case 'city': limitation = citySpeed; break;
        case 'residential': limitation = residentialSpeed; break;
        default: return;
    }

    if(speed > limitation){
        let difference = speed - limitation;

        if(difference <= 20){
            console.log('speeding');
        }
        else if(difference > 20 && difference <= 40){
            console.log('excessive speeding');
        }
        else{
            console.log('reckless driving');
        }

    }
}

solve(40, 'city');
solve(21, 'residential');
solve(120, 'interstate');
solve(200, 'motorway');
