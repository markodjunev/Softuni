function solve(){
    class Post{
        constructor(title, content){
            this.title = title;
            this.content = content;
        }

        toString(){
            return `Post: ${this.title}\n` + 
                   `Content: ${this.content}`;
        }
    }

    class SocialMediaPost extends Post{
        constructor(title, content, likes, dislikes){
            super(title, content);
            this.likes = Number(likes);
            this.dislikes = Number(dislikes);
            this.comments = [];    
        }

        addComment(text){
            this.comments.push(text);
        }

        toString() {
            let result = super.toString() + `\nRating: ${this.likes - this.dislikes}\n`

            if (this.comments.length > 0) {
                result += "Comments:\n"
                    + this.comments.reduce((acc, curr) => {
                        return acc += ` * ${curr}\n`
                    }, "");
            }
            return result.trimEnd(); 
        }
    }

    class BlogPost extends Post {
        constructor(title, content, views) {
            super(title, content);

            this.views = views;
        }

        view() {
            this.views++;
            return this;
        }

        toString() {
            return super.toString()
                + `\nViews: ${this.views}`
        }
    }

    return {
        Post,
        SocialMediaPost,
        BlogPost
    }
}