﻿let iconCart = document.querySelector('.icon-cart');
let closecart = document.querySelector('.close');
let body = document.querySelector('body');
iconCart.addEventListener('click', () => {
    console.log("hi");
    body.classList.add('showcart');
});
closecart.addEventListener('click', () => {
    body.classList.remove('showcart');
});

