const modal = document.getElementById('modal-perfil');
const botaoAbrir = document.getElementById('abrir-modal');
const botaoFechar = document.getElementById('fechar-modal');
const botaoFechar2 = document.getElementById('fechar-modal2');

const overlay = document.getElementById('modal-overlay');

// Abrir o modal quando o botão for clicado
botaoAbrir.addEventListener('click', () => {
    modal.classList.add('ativo');
    overlay.classList.add('ativo');
});

// Fechar o modal quando o botão de fechar for clicado
botaoFechar.addEventListener('click', () => {
    modal.classList.remove('ativo')
    overlay.classList.remove('ativo');
});

botaoFechar2.addEventListener('click', () => {
    modal.classList.remove('ativo');
    overlay.classList.remove('ativo');
});

overlay.addEventListener('click', () => {
    modal.classList.remove('ativo');
    overlay.classList.remove('ativo');
});

document.addEventListener('keydown', ESC => {
    if (ESC.key === 'Escape') {
        modal.classList.remove('ativo')
        overlay.classList.remove('ativo');
    }
});