function createArticle() {
	let title = document.getElementById('createTitle');
	let content = document.getElementById('createContent');
	let articles = document.getElementById('articles');
	let article = document.createElement('article');
	let h3 = document.createElement('h3');
	let p = document.createElement('p');

	if(title.value !== '' && content.value !== ''){
		h3.innerHTML = title.value;
		p.innerHTML = content.value;
		article.appendChild(h3);
		article.appendChild(p);
		articles.appendChild(article);
		title.value = '';
		content.value = '';
	}
}