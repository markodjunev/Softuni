function attachEventsListeners() {
    const days = document.querySelector('#days');
    const hours = document.querySelector('#hours');
    const minutes = document.querySelector('#minutes');
    const seconds = document.querySelector('#seconds');
    const buttons = document.querySelectorAll('input[type="button"]');

    Array.from(buttons).forEach(btn => {
        btn.addEventListener('click', function(e){
            const currentTarget = e.target.id;

            if (currentTarget === 'daysBtn') {
                const daysValue = days.value;
                hours.value = daysValue * 24;
                minutes.value = daysValue * 1440;
                seconds.value = daysValue * 86400;
            } else if (currentTarget === 'hoursBtn') {
                const hoursValue = hours.value;
                days.value = hoursValue / 24;
                minutes.value = hoursValue * 60;
                seconds.value = hoursValue * 3600;
            } else if (currentTarget === 'minutesBtn') {
                const minutesValue = minutes.value;
                days.value = minutesValue / 1440;
                hours.value = minutesValue / 60;
                seconds.value = minutesValue * 60;
            } else if (currentTarget === 'secondsBtn') {
                const secondsValue = seconds.value;
                days.value = secondsValue / 86400;
                hours.value = secondsValue / 3600;
                minutes.value = secondsValue / 60;
            }
        })
    });
}