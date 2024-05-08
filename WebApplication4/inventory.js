document.addEventListener('DOMContentLoaded', () => {
    let btn = document.querySelector('#btn');
    let moveform = document.querySelector('.inputForm');
    let btn1 = document.querySelector('#btn1');
    let coverr = document.querySelector('.notcover');
    let btn2 = document.querySelector('#btn2');
    let takeform = document.querySelector('.f1');
    btn.addEventListener('click', () => {
        console.log("hi");
        coverr.classList.remove('notcover');

        coverr.classList.add('cover');
        moveform.classList.add('moveee');
    });

    btn1.addEventListener('click', () => {
        coverr.classList.remove('cover');

        moveform.classList.remove('moveee');
    });
    btn2.addEventListener('click', () => {
        coverr.classList.remove('notcover');

        coverr.classList.add('cover');
        takeform.classList.add('moveee')

    });
    //let modeBtn = document.querySelector('.icon');
    //modeBtn.addEventListener('click', () => {
    //    let body = document.querySelector('body');
    //    body.setAttribute('style', 'background-color: black; color: white;');
    //});

});
