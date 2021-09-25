// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.
document.getElementById("searchButton").addEventListener("click", () => {
    let x = document.getElementById("searchInputField").value
    window.open('/search/' + x);
})
// Write your JavaScript code.
