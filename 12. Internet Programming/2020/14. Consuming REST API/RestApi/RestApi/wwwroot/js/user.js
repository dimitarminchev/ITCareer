let user;

$('#choose').on('click', () => {
  user = $('#username').val().trim();
  if (user === '') {
    user = undefined;
    return;
  }
  $('#choose-data').hide();
  $('#username-choice').html(document.createTextNode(user));
});

$('#reset').on('click', () => {
  $('#choose-data').show();
  $('#username-choice').html('');
  user = undefined;
});