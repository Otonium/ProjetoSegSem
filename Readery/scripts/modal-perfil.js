const modal = document.getElementById('modal-perfil');
const botaoAbrir = document.getElementById('abrir-modal');
const botaoFechar = document.getElementById('fechar-modal');

// Abrir o modal quando o botão for clicado
botaoAbrir.addEventListener('click', () => {
    modal.showModal(modal); // Use showModal() para o comportamento de modal
});

// Fechar o modal quando o botão de fechar for clicado
botaoFechar.addEventListener('click', () => {
    modal.close();
});