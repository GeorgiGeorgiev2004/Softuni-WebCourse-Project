"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/chatHub").build();

document.getElementById("sendButton").disabled = true;

connection.on("ReceiveMessage", function (message,datetime) {
    var li = document.createElement("li");
    var typeOfUser = document.getElementById("TypeOfUser").value;
    if (typeOfUser == "value") {
        li.classList.add('list-group-item','li_align_right');
    }
    else {
        li.classList.add('list-group-item')
    }
    var small = document.createElement("small");
    small.classList.add('text-muted', 'text-start');
    document.getElementById("messagesList").appendChild(small);
    document.getElementById("messagesList").appendChild(li);
    li.textContent = `${message}`;
    small.textContent = `Message sent on: ${datetime}`;
    document.getElementById("messageInput").value='';
});

connection.start().then(function () {
    document.getElementById("sendButton").disabled = false;
}).catch(function (err) {
    return console.error(err.toString());
});

document.getElementById("sendButton").addEventListener("click", function (event) {
    var userId = document.getElementById("userInput").value;
    var conversationId = document.getElementById("conversationId").value;
    var message = document.getElementById("messageInput").value;
    if (message == "") {
        message = prompt("Please enter a valid message");
    }
    connection.invoke("SaveMessage", userId, message, conversationId).catch(function (err) {
        return console.error(err.toString());
    });
    connection.invoke("SendMessage", message).catch(function (err) {
        return console.error(err.toString());
    });
    event.preventDefault();
});