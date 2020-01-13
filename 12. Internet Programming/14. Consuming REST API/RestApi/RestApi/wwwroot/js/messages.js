class Messages {
  get messages() {
    return this.messagesArray;
  }
  set messages(arr) {
    this.messagesDiv.html('');
    this.messagesArray = arr;
    this.messagesArray.forEach(message => {
      const div = $('<div></div>');
      div.addClass('message d-flex justify-content-start');
      const strong = $('<strong></strong>');
      strong.text(message.user);
      div.append(strong);
      div.append(': ');
      div.append(document.createTextNode(message.content));
      div.on('contextmenu', ({ originalEvent }) => {
        originalEvent.preventDefault();
        const origin = {
          left: originalEvent.pageX,
          top: originalEvent.pageY
        };
        setPosition(origin, message);
        return false;
      });
      this.messagesDiv.append(div);
    });
    this.messagesDiv.scrollTop(this.messagesDiv.height());
  }

  constructor() {
    this.messagesDiv = $('#messages');
    this.messageInput = $('#message');
    this.messagesArray = [];
    this.url = window.location.href.replace('index.html', '') + 'api/messages/';
    this.messageInput.on('keydown', event => {
      if (event.key === 'Enter') {
        this.sendMessage();
      }
    });
    setInterval(() => {
      this.getMessages();
    }, 10 * 1000);
  }

  getMessages() {
    $.ajax({
      headers: {
        Accept: 'application/json'
      },
      type: 'GET',
      url: this.url + 'all',
      success: res => this.messages = res,
      error: err => console.error(err)
    });
  }

  sendMessage() {
    if (!user) {
      return;
    }
    const value = this.messageInput.val();
    this.messageInput.val('');
    if (!this.editId) {
      $.ajax({
        headers: {
          Accept: 'application/json',
          'Content-Type': 'application/json'
        },
        type: 'POST',
        url: this.url + 'create',
        data: JSON.stringify({
          content: value,
          user,
        }),
        success: () => { this.getMessages(); },
        error: err => console.error(err)
      });
    } else {
      $.ajax({
        headers: {
          'Content-Type': 'application/json'
        },
        type: 'PUT',
        url: this.url + `edit/${this.editId}`,
        data: JSON.stringify(value),
        success: () => {
          this.editId = undefined;
          this.getMessages();
        },
        error: err => console.error(err)
      });
    }
  }

  deleteMessage(id) {
    $.ajax({
      type: 'DELETE',
      url: this.url + `delete/${id}`,
      success: () => { this.getMessages() },
      error: err => console.error(err)
    });
  }

  editMessage({ id, content }) {
    this.editId = id;
    this.messageInput.val(content);
  }
}

const messageClass = new Messages();

$(document).ready(() => {
  messageClass.getMessages();
});

$('#send').on('click', () => {
  messageClass.sendMessage();
});