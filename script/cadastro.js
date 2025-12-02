//* Coleta de dados do HTML

const elIdNome = document.querySelector('#name')

const elIdEmail = document.querySelector('#email')

const elIdSenha = document.querySelector('#senha')

const elIdCampoDados = document.querySelector('#form-dados')

const botaoCadastro = elIdCampoDados.querySelector('.cadastro');


//* Salvar informacoes do usuario
elIdCampoDados.addEventListener('submit', n =>{

    //impedir o comportamento padrao de recarregar a pagina
    n.preventDefault();

    const nome = elIdNome.value.trim();
    const email = elIdEmail.value.trim();
    const senha = elIdSenha.value.trim();
    
    if(!nome || !senha || !email){ 
     
      const h3 = document.createElement('h3')  
      h3.className = "Falha"
      h3.textContent = "Elemento nao preenchido corretamente"
      h3.dataset.id = h3.id

      console.log(elIdCampoDados.childNodes)

      const erroExistente = elIdCampoDados.querySelector('.Falha')
      if (erroExistente) {
        erroExistente.remove();
      }

      elIdCampoDados.insertBefore(h3, botaoCadastro);
      return;
  }

    console.log(nome)
    console.log(email)
    console.log(senha)
})