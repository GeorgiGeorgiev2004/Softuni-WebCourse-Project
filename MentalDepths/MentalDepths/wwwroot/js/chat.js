"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/chatHub").build();

document.getElementById("sendButton").disabled = true;

connection.on("ReceiveMessage", function (message,datetime) {
    var li = document.createElement("li");
    li.classList.add('list-group-item');
    var small = document.createElement("small");
    small.classList.add('text-muted', 'text-start');
    document.getElementById("messagesList").appendChild(small);
    document.getElementById("messagesList").appendChild(li);
    li.textContent = `${message}`;
    small.textContent = `Message sent on: ${datetime}`;
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

    connection.invoke("SendMessage",message).catch(function (err) {
        return console.error(err.toString());
    });
    connection.invoke("SaveMessage", userId, message, conversationId).catch(function (err) {
        return console.error(err.toString());
    });
    event.preventDefault();
});