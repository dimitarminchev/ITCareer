let menuDiv;
let menuVisible = false;

function toggleMenu(command) {
  if (command === 'hide') {
    menuDiv.remove();
    menuDiv = undefined;
  }
  menuVisible = !menuVisible;
}

function setPosition({ top, left }, message) {
  if (menuVisible) {
    menuDiv.remove();
    menuDiv = undefined;
  }
  createMenu(message);
  menuDiv.css({ left: `${left}px`, top: `${top}px` });
  toggleMenu('show');
}

function createMenu(message) {
  menuDiv = $('<div></div>');

  menuDiv.addClass('menu');

  const list = $('<ul></ul>');
  list.addClass('menu-options');

  if (message.user === user) {
    const deleteEl = $('<li></li>');
    deleteEl.html('Delete');
    deleteEl.addClass('menu-option');
    deleteEl.on('click', () => {
      messageClass.deleteMessage(message.id);
    });
    list.append(deleteEl);
    const editEl = $('<li></li>');
    editEl.html('Edit');
    editEl.addClass('menu-option');
    editEl.on('click', () => {
      messageClass.editMessage(message);
    });
    list.append(editEl);
  }
  const idEl = $('<li></li>');
  idEl.html('Alert Id');
  idEl.addClass('menu-option');
  idEl.on('click', () => {
    alert(message.id);
  });
  list.append(idEl);
  const createdEl = $('<li></li>');
  createdEl.html('Alert Created Date');
  createdEl.addClass('menu-option');
  createdEl.on('click', () => {
    alert(message.createdOn);
  });
  list.append(createdEl);

  menuDiv.append(list);

  $(document.body).append(menuDiv);
}

$('*').on('click', () => {
  if (menuVisible) {
    toggleMenu('hide');
  }
});
