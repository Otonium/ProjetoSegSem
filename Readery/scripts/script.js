let button = document.getElementById('botao-card');

let estrela1 = document.getElementById('1');
let estrela2 = document.getElementById('2');
let estrela3 = document.getElementById('3');
let estrela4 = document.getElementById('4');
let estrela5 = document.getElementById('5');

let estrela = document.querySelector(".estrela");
let estrela22 = document.querySelector(".estrela2");
let estrela33 = document.querySelector(".estrela3");
let estrela44 = document.querySelector(".estrela4");
let estrela55 = document.querySelector(".estrela5");

let nota = document.querySelector(".nota");

button.addEventListener('click', function(){
    let card = document.querySelector(".card-dentro");
    card.classList.toggle('active');
    if(button.textContent == "↑"){
        button.textContent = "↓";
    }
    else{
        button.textContent = "↑";
    }
});

//* estrelas

estrela1.addEventListener('click', function(){
    

    if(estrela.textContent == "☆"){
        estrela.textContent = "★";
        nota.textContent = "1/5";
    }
    else if(estrela.textContent == "★"){
        estrela.textContent = "☆";
        estrela22.textContent = "☆";
        estrela33.textContent = "☆";
        estrela44.textContent = "☆";
        estrela55.textContent = "☆";
        nota.textContent = "0/5";
    }
})

estrela2.addEventListener('click', function(){
    
    if(estrela22.textContent == "☆"){
        estrela.textContent = "★"
        estrela22.textContent = "★";
        nota.textContent = "2/5";
    }
    else if(estrela22.textContent == "★"){
        estrela22.textContent = "☆";
        estrela33.textContent = "☆";
        estrela44.textContent = "☆";
        estrela55.textContent = "☆";
        nota.textContent = "1/5";
    }
})

estrela3.addEventListener('click', function(){
    
    if(estrela33.textContent == "☆"){
        estrela.textContent = "★"
        estrela22.textContent = "★";
        estrela33.textContent = "★";
        nota.textContent = "3/5";
    }   
    else if(estrela33.textContent == "★"){
        estrela33.textContent = "☆"
        estrela44.textContent = "☆";
        estrela55.textContent = "☆";
        nota.textContent = "2/5";
    }
})

estrela4.addEventListener('click', function(){
    
    if(estrela44.textContent == "☆"){
        estrela.textContent = "★"
        estrela22.textContent = "★";
        estrela33.textContent = "★";
        estrela44.textContent = "★";
        nota.textContent = "4/5";
    }
    else if(estrela44.textContent == "★"){
        estrela44.textContent = "☆";
        estrela55.textContent = "☆";
        nota.textContent = "3/5";
    }
})

estrela5.addEventListener('click', function(){
    
    if(estrela55.textContent == "☆"){
        estrela.textContent = "★"
        estrela22.textContent = "★";
        estrela33.textContent = "★";
        estrela44.textContent = "★";
        estrela55.textContent = "★";
        nota.textContent = "5/5";
    }
    else if(estrela55.textContent == "★"){
        estrela55.textContent = "☆";
        nota.textContent = "4/5";
    }
})