function getArticleGenerator(articles) {
    let divElement = document.getElementById("content");

    return prependArticle;

    function prependArticle() {

        let currentArticle = articles.shift()

        if (currentArticle) {
            let div = document.createElement("article");
            div.textContent = currentArticle;

            divElement.appendChild(div);
        }

    }
}