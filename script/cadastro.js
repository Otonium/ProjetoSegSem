//* Coleta de dados do HTML

const elNome = document.getElementById('campo-nome')
const elIdNome = document.querySelector('#name')

const elEmail = document.getElementById('campo-email')
const elIdEmail = document.getElementById('email')

const elSenha = document.getElementById('campo-senha')
const elIdSenha = document.getElementById('senha')

//* Salvar informacoes do nome

elNome.addEventListener('submit', n =>{

    //impedir o comportamento padrao de recarregar a pagina
    n.preventDefault();

    const nome = elIdNome.value.trim();

    if(!nome) return;

    console.log(nome);
})