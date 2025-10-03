//* variaveis de botoes do card

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


const elBotaoAdiciona = document.getElementById('adiciona-livro');
const elFiltroGenero = document.getElementById('filtro-genero');
const elSecaoLivros = document.querySelector(".secao-livros");
const imagens = document.querySelector(".img-card2");

let listaLivros = [];

elBotaoAdiciona.addEventListener('click', function () {
    const nova = { id: Date.now(), titulo: "A Divina Comédia", status: "lendo", autor: "Dante Alighieri", genero: "poesia" }
    listaLivros.push(nova);

    console.log(listaLivros);
    render();
});

function render() {

    const filtro = elFiltroGenero.value;

    const filtradas = listaLivros.filter(function (t) {
        const okGenero = filtro === "todos" ? true : t.genero === filtro;

        return okGenero;
    });

    elSecaoLivros.innerHTML = "";

    filtradas.forEach(function (t) {


        const div = document.createElement("div");
        div.className = "espaco-card";

        const divCard = document.createElement("div");
        divCard.className = "card-dentro";

        const divLixeira = document.createElement("div");
        divLixeira.className = "lixeira";

        const botaoRemover = document.createElement("button");
        botaoRemover.textContent = "X";
        botaoRemover.className = "remover";

        botaoRemover.addEventListener('click', function () {
            modal.showModal();
        })

        const modal = document.createElement("dialog");
        modal.className = 'meu-modal';

        const textoModal = document.createElement("h1");
        textoModal.className = "texto-modal";
        textoModal.textContent = "Deseja mesmo excluir o livro?";

        const botaoCancelarModal = document.createElement("button");
        botaoCancelarModal.className = "botao-cancela-modal";
        botaoCancelarModal.textContent = "Cancelar";

        botaoCancelarModal.addEventListener('click', function () {
            modal.close();
        })

        const botaoExcluirModal = document.createElement("button");
        botaoExcluirModal.className = "botao-exclui-modal";
        botaoExcluirModal.textContent = "Excluir";

        botaoExcluirModal.addEventListener('click', function () {
            listaLivros = listaLivros.filter(apagar => apagar.id !== t.id);
            modal.close();
            render();
        })

        const divModal = document.createElement("div");
        divModal.className = "div-Modal";

        const botaoImagemCard = document.createElement("button");
        botaoImagemCard.className = "botao-imagem-card";

        const imagem = document.createElement("img");
        imagem.src = "assets/img/placeholder.svg";
        imagem.className = "img-card";

        const divTextos = document.createElement("div");
        divTextos.className = "textos";

        const textoCard = document.createElement("p");
        textoCard.className = "text-card";
        textoCard.textContent = "Lorem Ipsum is simply dummy text of the printing and ty Lorem Ipsum Dolor is simply.Lorem Ipsum is simply dummy text of the printing and ty Lorem Ipsum Dolor is simply.Lorem Ipsum is simply dummy text of the printing and ty Lorem Ipsum Dolor is simply."

        const botaoCard = document.createElement("button");
        botaoCard.className = "botao-card";
        botaoCard.textContent = "↓";

        botaoCard.addEventListener('click', function () {
            let card = document.querySelector(".card-dentro");
            card.classList.toggle('active');
            if (botaoCard.textContent == "↑") {
                botaoCard.textContent = "↓";
            }
            else {
                botaoCard.textContent = "↑";
            }
        });


        divCard.appendChild(divLixeira);
        divCard.appendChild(botaoImagemCard);
        divCard.appendChild(divTextos);
        divCard.appendChild(botaoCard);
        divCard.appendChild(modal);

        botaoImagemCard.appendChild(imagem);

        modal.appendChild(textoModal);
        modal.appendChild(divModal);
        divModal.appendChild(botaoCancelarModal);
        divModal.appendChild(botaoExcluirModal);


        divLixeira.appendChild(botaoRemover);
        divTextos.appendChild(textoCard);

        div.appendChild(divCard);
        elSecaoLivros.appendChild(div);

    });
}






//* estrelas

estrela1.addEventListener('click', function () {

    if (estrela.textContent == "☆") {
        estrela.textContent = "★";
        nota.textContent = "1/5";
    }
    else if (estrela.textContent == "★") {
        estrela.textContent = "☆";
        estrela22.textContent = "☆";
        estrela33.textContent = "☆";
        estrela44.textContent = "☆";
        estrela55.textContent = "☆";
        nota.textContent = "0/5";
    }
})

estrela2.addEventListener('click', function () {

    if (estrela22.textContent == "☆") {
        estrela.textContent = "★"
        estrela22.textContent = "★";
        nota.textContent = "2/5";
    }
    else if (estrela22.textContent == "★") {
        estrela22.textContent = "☆";
        estrela33.textContent = "☆";
        estrela44.textContent = "☆";
        estrela55.textContent = "☆";
        nota.textContent = "1/5";
    }
})

estrela3.addEventListener('click', function () {

    if (estrela33.textContent == "☆") {
        estrela.textContent = "★"
        estrela22.textContent = "★";
        estrela33.textContent = "★";
        nota.textContent = "3/5";
    }
    else if (estrela33.textContent == "★") {
        estrela33.textContent = "☆"
        estrela44.textContent = "☆";
        estrela55.textContent = "☆";
        nota.textContent = "2/5";
    }
})

estrela4.addEventListener('click', function () {

    if (estrela44.textContent == "☆") {
        estrela.textContent = "★"
        estrela22.textContent = "★";
        estrela33.textContent = "★";
        estrela44.textContent = "★";
        nota.textContent = "4/5";
    }
    else if (estrela44.textContent == "★") {
        estrela44.textContent = "☆";
        estrela55.textContent = "☆";
        nota.textContent = "3/5";
    }
})

estrela5.addEventListener('click', function () {

    if (estrela55.textContent == "☆") {
        estrela.textContent = "★"
        estrela22.textContent = "★";
        estrela33.textContent = "★";
        estrela44.textContent = "★";
        estrela55.textContent = "★";
        nota.textContent = "5/5";
    }
    else if (estrela55.textContent == "★") {
        estrela55.textContent = "☆";
        nota.textContent = "4/5";
    }
})