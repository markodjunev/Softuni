/* globals Handlebars*/

window.addEventListener('load', async () => {
    const templateString = await (await fetch('./main-template.hbs')).text();
    Handlebars.registerPartial('town', await (await fetch('./town-template.hbs')).text());

    document.querySelector('#btnLoadTowns').addEventListener('click', renderTowns);
    const input = document.querySelector('#towns');
    const rootEl = document.querySelector('#root');

    function renderTowns(e) {
        e.preventDefault();
        
        const towns = input.value.split(', ');
        const templateFn = Handlebars.compile(templateString);
        const generatedHtml = templateFn({ towns });

        rootEl.innerHTML = generatedHtml;
    }
})