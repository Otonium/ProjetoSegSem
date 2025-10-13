document.addEventListener('DOMContentLoaded', function () {
    const form = document.getElementById('resetForm');
    const inputEmail = document.getElementById('email');
    const mensagemFeedback = document.getElementById('mensagemFeedback');


    const EMAIL_REGISTRADO = 'teste@readery.com.br';

    if (form) {
        form.addEventListener('submit', function (event) {
            event.preventDefault();

            mensagemFeedback.style.visibility = 'hidden';
            inputEmail.classList.remove('input-error');

            const email = inputEmail.value.trim();

            if (email === '') {
                exibirFeedback('Por favor, insira um endereço de e-mail.', 'error');
                inputEmail.classList.add('input-error');
                return;
            }

            if (email === EMAIL_REGISTRADO) {
                exibirFeedback('Link de redefinição enviado para o seu e-mail!', 'success');
                form.reset();
            } else {
                exibirFeedback('Email não registrado.', 'info');
            }
        });
    }

    function exibirFeedback(mensagem, tipo) {
        mensagemFeedback.textContent = mensagem;

        if (tipo === 'error') {
            mensagemFeedback.style.color = '#B40000';
        } else if (tipo === 'success') {
            mensagemFeedback.style.color = 'green';
        } else if (tipo === 'info') {
            mensagemFeedback.style.color = '#8E7253';
        }

        mensagemFeedback.style.visibility = 'visible';
    }
});