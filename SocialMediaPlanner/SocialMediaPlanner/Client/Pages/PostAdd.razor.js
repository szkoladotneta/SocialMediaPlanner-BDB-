export function AddTextToTextbox(message, dotNetObject) {
    var title = document.getElementById("title");
    title.value = message;

    dotNetObject.invokeMethodAsync("AddText");
}