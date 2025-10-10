//* Coleta de dados do HTML

const elDados = document.getElementById('form-dados')

const elIdNome = document.querySelector('#name')

const elIdEmail = document.querySelector('#email')

const elIdSenha = document.querySelector('#senha')

const elIdCampoDados = document.querySelector('#form-dados')

//* Salvar informacoes do usuario
elDados.addEventListener('submit', n =>{

    //impedir o comportamento padrao de recarregar a pagina
    n.preventDefault();

    const nome = elIdNome.value.trim();
    const email = elIdEmail.value.trim();
    const senha = elIdSenha.value.trim();

    if(!nome || !senha || !email){ 
    let 
      const h3 = document.createElement('h3')  
      h3.className = "Falha"
      h3.textContent = "Elemento nao preenchido corretamente"
      h3.dataset.id = h3.id

      elIdCampoDados.appendChild(h3); // adiciona o aviso à página
        return;
    }

    console.log(nome)
    console.log(email)
    console.log(senha)
})