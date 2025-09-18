//* Coleta de dados do HTML

const elDados = document.getElementById('form-dados')

const elIdNome = document.querySelector('#name')

const elIdEmail = document.querySelector('#email')

const elIdSenha = document.querySelector('#senha')

//* Salvar informacoes do usuario
elDados.addEventListener('submit', n =>{

    //impedir o comportamento padrao de recarregar a pagina
    n.preventDefault();

    const nome = elIdNome.value.trim();
    const email = elIdEmail.value.trim();
    const senha = elIdSenha.value.trim();

    if(!nome) return;
    if(!senha) return;
    if(!email) return;

    console.log(nome)
    console.log(senha)
    console.log(email)
})