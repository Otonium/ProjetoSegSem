document.addEventListener('DOMContentLoaded', function() {
    
    const form = document.getElementById('loginForm');
    const inputUsuario = document.getElementById('usuario');
    const inputSenha = document.getElementById('senha');
    const mensagemErro = document.getElementById('mensagemErro'); 

    const USUARIO_CORRETO = 'admin';
    const SENHA_CORRETA = '12345'; 

    if (form) {
        form.addEventListener('submit', function(event) {
            event.preventDefault(); 
            
            mensagemErro.style.visibility = 'hidden';
            inputUsuario.classList.remove('input-error');
            inputSenha.classList.remove('input-error');

            const usuario = inputUsuario.value.trim();
            const senha = inputSenha.value.trim();

            if (usuario === '' || senha === '') {
                mensagemErro.textContent = 'Por favor, preencha todos os campos.';
                mensagemErro.style.visibility = 'visible';
                return; 
            }

            if (usuario !== USUARIO_CORRETO || senha !== SENHA_CORRETA) {
                mensagemErro.style.visibility = 'visible';
                
                inputUsuario.classList.add('input-error');
                inputSenha.classList.add('input-error');
                
            } else {
                mensagemErro.textContent = 'Login realizado com sucesso!';
                mensagemErro.style.visibility = 'visible';
                mensagemErro.style.color = 'green';
            }
        });
    }
    
    inputUsuario.addEventListener('input', () => inputUsuario.classList.remove('input-error'));
    inputSenha.addEventListener('input', () => inputSenha.classList.remove('input-error'));
});