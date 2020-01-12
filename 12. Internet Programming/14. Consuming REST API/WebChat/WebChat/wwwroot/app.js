/*
/api/messages/all – Връща всички съобщения, подредени по CreatedOn
/api/messages/create – създава съобщение по дадено съдържание и потребител
/api/messages/edit/{id} – актуализира съобщение по дадено id и съдържание
/api/messages/delete/{id} – изтрива съобщение по дадено id
*/

// 10 Seconds Timer
window.setTimeout(function () {
    alert('10 Seconds Timer');
}, 10000);

// reset button clicked
$("#reset").click(function () {
    alert('reset button clicked');
});

// choose button clicked
$("#choose").click(function () {
    alert('choose button clicked');
});

// Get Example
$.get("ajax/test.html", function (data) {
    $(".result").html(data);
    alert("Load was performed.");
});

// Post Example
$.post("api/messages/all", { name: "John", time: "2pm" });


