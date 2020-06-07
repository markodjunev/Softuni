function solve() {
   let messages = document.querySelector("#chat_messages");
   document.querySelector('button').addEventListener('click', sendMessage);

   function sendMessage(){
      let input = document.querySelector('#chat_input').value;

      let div = document.createElement('div');
      div.setAttribute('class', 'message my-message');
      div.textContent = input;
      messages.appendChild(div);

      document.querySelector('#chat_input').value = '';
   }
}
