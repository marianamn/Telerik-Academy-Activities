//JSLint is used as a tool

/*global window: false */
function isBrowserMozilla() {
    var currentBrowser,
        textToShow;

    currentBrowser = window.navigator.appCodeName;

    textToShow = "Browser Name: " + currentBrowser;
    window.document.getElementById("current-browser").innerHTML = textToShow;

    if (currentBrowser === "Mozilla") {
        window.alert("Yes");
    } else {
        window.alert("No");
    }
}