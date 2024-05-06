let btn = document.querySelector('btn');
let closecart = document.querySelector('.close');
let body = document.querySelector('body');
btn.addEventListener('click', () => {
    console.log("hi");
    body.classList.add('showcart');
});
closecart.addEventListener('click', () => {
    body.classList.remove('showcart');
});