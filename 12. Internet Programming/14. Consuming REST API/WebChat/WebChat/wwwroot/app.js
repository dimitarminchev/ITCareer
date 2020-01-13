// part 1. Get All Messages Every Second
setInterval(function () {
    $.getJSON("api/messages/all", function (json) {
        $("#messages").empty();
        $.each(json, function (index, obj) {
            var line = '<div class="message d-flex justify-content-start"><strong>' + obj.user + '</strong>: ' + obj.content + '</div>';
            $("#messages").append(line);
        });
    })
},1000);

// part 2. Choose Username
$("#choose").click(function () {
    $("#username-choice").text($("#username").val());
    $("#username").val(null);
});

// part 3. Reset Username
$("#reset").click(function () {
    $("#username-choice").empty();
});

// Post Helper Function
(function ($) {
    $.postJSON = function (url, data) {
        var o = {
            url: url,
            type: "POST",
            dataType: "json",
            contentType: 'application/json; charset=utf-8'
        };
        if (data !== undefined) {
            o.data = JSON.stringify(data);
        }
        return $.ajax(o);
    };
}(jQuery));

// Part 4. Send Message
$("#send").click(function () {
    $.postJSON('api/messages/create', { user: $("#username-choice").text(), content: $("#message").val() });
    $("#message").val(null);
});