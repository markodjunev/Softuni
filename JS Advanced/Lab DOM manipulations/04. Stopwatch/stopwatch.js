function stopwatch() {
    let seconds = 0;
    let minutes = 0;
    let intervalId;
    const startBtn = document.getElementById('startBtn');
    const stopBtn = document.getElementById('stopBtn');
    let time = document.getElementById('time');

    function formatOutput(val){
        let text = val.toString();
        if(val < 10){
            text = '0' + text;
        }

        return text;
    }

    function start(e){
        minutes = 0;
        seconds = 0;
        time.innerText = `${formatOutput(minutes)}:${formatOutput(seconds)}`;
        startBtn.setAttribute('disabled', true);
        stopBtn.removeAttribute('disabled');

        intervalId = setInterval(function (){
            seconds++;
            if(seconds === 60){
                seconds = 0;
                minutes++;
            }

            time.innerText = `${formatOutput(minutes)}:${formatOutput(seconds)}`;
        }, 1000)
    }

    function stop(e){
        stopBtn.setAttribute('disabled', true);
        startBtn.removeAttribute('disabled');
        clearInterval(intervalId);
    }

    startBtn.addEventListener('click', start);
    stopBtn.addEventListener('click', stop);
}