function solve(){
    class Article{
        constructor(title, content){
            this.title = title;
            this.content = content;
        }

        toString(){
            return `Title: ${this.title}\n` +
                   `Content: ${this.content}`;
        }
    }

    class ShortReports extends Article{
        constructor(title, content, originalResearch){
            if(content.length >= 150){
                throw new Error("Short reports content should be less then 150 symbols.");
            } else if(!originalResearch.hasOwnProperty('title') || !originalResearch.hasOwnProperty('author')){
                throw new Error("The original research should have author and title.");
            }

            super(title, content);
            this.originalResearch = originalResearch;
            this.comments = [];
        }

        addComment(comment){
            this.comments.push(comment);
            return "The comment is added.";
        }

        toString(){
            let result = super.toString();
            result += `\nOriginal Research: ${this.originalResearch.title} by ${this.originalResearch.author}`;
            if (this.comments.length > 0) {
                result += '\nComments:\n';
                result += this.comments.join('\n');
            }
            return result;
        }
    }

    class BookReview extends Article{
        constructor(title, content, book){
            super(title, content);
            this.book = book;  
            this.clients = [];
        }

        addClient(clientName,  orderDescription){
            this.clients.map(client => {
                if (client.name === clientName) {
                    throw new Error(`This client has already ordered this review.`);
                }
            });

            let client = {name: clientName, order: orderDescription};
            this.clients.push(client);
            return `${clientName} has ordered a review for ${this.book.name}`;
        }

        toString() {
            let result = super.toString();
            result += `\nBook: ${this.book.name}`;
            if (this.clients.length > 0) {
                result += `\nOrders:`;
                this.clients.map(client => {
                    result += `\n${client.name} - ${client.order}.`;
                });
            }
            return result;
        }
    }

    return {
        Article,
        ShortReports,
        BookReview
    }
}