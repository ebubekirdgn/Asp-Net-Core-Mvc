document.addEventListener("DOMContentLoaded", function () {
    var element = document.createElement("p");
    element.textContent = "script 1 den gelen içerik";
    document.querySelector("body").appendChild(element);
});
document.addEventListener("DOMContentLoaded", function () {
    var element = document.createElement("p");
    element.textContent = "script 2 den gelen içerik";
    document.querySelector("body").appendChild(element);
});