//* variaveis de botoes do card

let button = document.getElementById('botao-card');

const elBotaoAdiciona = document.getElementById('adiciona-livro');
const elFiltroGenero = document.getElementById('filtro-genero');
const elSecaoLivros = document.querySelector(".secao-livros");
const imagens = document.querySelector(".img-card2");
const elSecaoModalCards = document.querySelector(".secao-modal-cards");

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

        botaoImagemCard.addEventListener('click', function(){

        })

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


        //* CARD FORA
        const divCardFora = document.createElement("div")
        divCardFora.className = "card-fora"
        
        const tituloLivro = document.createElement("p")
        tituloLivro.className = "titulo-livro"
        tituloLivro.textContent = "A Divina Comédia"

        const divNotas = document.createElement("div")
        divNotas.className = "notas";
        
        const textoNota = document.createElement("p")
        textoNota.className = "nota"
        textoNota.textContent = "0/5"

        //* MODAL CARD
        const ModalCard = document.createElement("dialog")
        ModalCard.className = "modal-card"

        const FechaModalCard = document.createElement("div")
        FechaModalCard.className = "fecha-modal-card"

        const ModalCardCima = document.createElement("div")
        ModalCardCima.className = "modal-card-parte1"

        const ModalCardBaixo = document.createElement("div")
        ModalCardBaixo.className = "modal-card-parte2"

        const LinhaUmModalCard = document.createElement("hr")
        LinhaUmModalCard.className = "linha-modal"

        const LinhaDoisModalCard = document.createElement("hr")
        LinhaDoisModalCard.className = "linha-modal2"

        const BotaoFechaModal = document.createElement("button")
        BotaoFechaModal.className = "botao-cancela-modal2"
        BotaoFechaModal.textContent = "X"








        //* ESTRELAS
        const botaoEstrela1 = document.createElement("button")
        botaoEstrela1.className = "estrela"
        botaoEstrela1.textContent = "☆"

        const botaoEstrela2 = document.createElement("button")
        botaoEstrela2.className = "estrela2"
        botaoEstrela2.textContent = "☆"

        const botaoEstrela3 = document.createElement("button")
        botaoEstrela3.className = "estrela3"
        botaoEstrela3.textContent = "☆"

        const botaoEstrela4 = document.createElement("button")
        botaoEstrela4.className = "estrela4"
        botaoEstrela4.textContent = "☆"

        const botaoEstrela5 = document.createElement("button")
        botaoEstrela5.className = "estrela5"
        botaoEstrela5.textContent = "☆"


        //* ESTRELAS FUNCIONANDO

        botaoEstrela1.addEventListener('click', function(){
            if (botaoEstrela1.textContent == "☆") {
                botaoEstrela1.textContent = "★";
                textoNota.textContent = "1/5";
            }
            else if (botaoEstrela1.textContent == "★") {
                botaoEstrela1.textContent = "☆";
                botaoEstrela2.textContent = "☆";
                botaoEstrela3.textContent = "☆";
                botaoEstrela4.textContent = "☆";
                botaoEstrela5.textContent = "☆";
                textoNota.textContent = "0/5";
            }
        })

        botaoEstrela2.addEventListener('click', function(){
            if (botaoEstrela2.textContent == "☆") {
                botaoEstrela1.textContent = "★"
                botaoEstrela2.textContent = "★";
                textoNota.textContent = "2/5";
            }
            else if (botaoEstrela2.textContent == "★") {
                botaoEstrela2.textContent = "☆";
                botaoEstrela3.textContent = "☆";
                botaoEstrela4.textContent = "☆";
                botaoEstrela5.textContent = "☆";
                textoNota.textContent = "1/5";
            }
        })

        botaoEstrela3.addEventListener('click', function(){
            if (botaoEstrela3.textContent == "☆") {
                botaoEstrela1.textContent = "★"
                botaoEstrela2.textContent = "★";
                botaoEstrela3.textContent = "★";
                textoNota.textContent = "3/5";
            }
            else if (botaoEstrela3.textContent == "★") {
                botaoEstrela3.textContent = "☆"
                botaoEstrela4.textContent = "☆";
                botaoEstrela5.textContent = "☆";
                textoNota.textContent = "2/5";
            }
        })

        botaoEstrela4.addEventListener('click', function(){
            if (botaoEstrela4.textContent == "☆") {
                botaoEstrela1.textContent = "★"
                botaoEstrela2.textContent = "★";
                botaoEstrela3.textContent = "★";
                botaoEstrela4.textContent = "★";
                textoNota.textContent = "4/5";
            }
            else if (botaoEstrela4.textContent == "★") {
                botaoEstrela4.textContent = "☆";
                botaoEstrela5.textContent = "☆";
                textoNota.textContent = "3/5";
            }
        })

        botaoEstrela5.addEventListener('click', function(){
            if (botaoEstrela5.textContent == "☆") {
                botaoEstrela1.textContent = "★"
                botaoEstrela2.textContent = "★";
                botaoEstrela3.textContent = "★";
                botaoEstrela4.textContent = "★";
                botaoEstrela5.textContent = "★";
                textoNota.textContent = "5/5";
            }
            else if (botaoEstrela5.textContent == "★") {
                botaoEstrela5.textContent = "☆";
                textoNota.textContent = "4/5";
            }
        })


        divCard.appendChild(divLixeira);
        divCard.appendChild(botaoImagemCard);
        divCard.appendChild(divTextos);
        divCard.appendChild(botaoCard);
        divCard.appendChild(modal);

        divNotas.appendChild(textoNota);
        divNotas.appendChild(botaoEstrela1);
        divNotas.appendChild(botaoEstrela2);
        divNotas.appendChild(botaoEstrela3);
        divNotas.appendChild(botaoEstrela4);
        divNotas.appendChild(botaoEstrela5);

        divCardFora.appendChild(divNotas);
        divCardFora.appendChild(tituloLivro);

        botaoImagemCard.appendChild(imagem);

        modal.appendChild(textoModal);
        modal.appendChild(divModal);
        divModal.appendChild(botaoCancelarModal);
        divModal.appendChild(botaoExcluirModal);


        elSecaoModalCards.appendChild(ModalCard);
        ModalCard.appendChild(FechaModalCard);
        ModalCard.appendChild(ModalCardCima);
        ModalCard.appendChild(LinhaUmModalCard);
        ModalCard.appendChild(LinhaDoisModalCard);
        ModalCard.appendChild(ModalCardBaixo);



        divLixeira.appendChild(botaoRemover);
        divTextos.appendChild(textoCard);

        div.appendChild(divCard);
        div.appendChild(divCardFora);
        elSecaoLivros.appendChild(div);

    });
}
