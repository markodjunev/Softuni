function loadRepos() {
	const input = document.getElementById("username");
    const repos = document.getElementById("repos");

    const url = `https://api.github.com/users/${input.value}/repos`;

    fetch(url)
        .then(respone => respone.json())
        .then(respone => {
            repos.innerHTML = "";

            respone.forEach(item => {
                const li = document.createElement("li");
                const a = document.createElement("a");

                a.href = item.html_url;
                a.innerText = item.full_name;
                li.appendChild(a);

                repos.appendChild(li);
            })
        })
}