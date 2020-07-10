function getInfo() {
    const validBusIDs = ["1287", "1308", "1327", "2334"];

    const stopId = document.getElementById("stopId").value;
    const stopNameDiv = document.getElementById("stopName");
    const buses = document.getElementById("buses");

    stopNameDiv.textContent = "";
    buses.innerHTML = "";

    if (validBusIDs.includes(stopId)) {
        const baseUrl = `https://judgetests.firebaseio.com/businfo/${stopId}.json`;

        let obj;

        fetch(baseUrl)
            .then(result => result.json())
            .then(item => {
                obj = item
            })
            .then(() => {
                stopNameDiv.textContent = obj.name;

                for (const [busId, time] of Object.entries(obj.buses)) {
                    const li = document.createElement("li");
                    li.textContent = `Bus ${busId} arrives in ${time} minutes`;
                    buses.appendChild(li);
                }
            })
    } else {
        stopNameDiv.textContent = "Error";
    }
}