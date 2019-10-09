// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.
const container = document.getElementById("site-container");
window.addEventListener("scroll",e =>
{
        container.style.transform = "translateY(0%)";
        console.log("showme");
        content_hidden = false;
});
