// Pega os elementos basicos do modal
const modal = document.getElementById('modal-perfil');
const botaoAbrir = document.getElementById('abrir-modal');
const botaoFechar = document.getElementById('fechar-modal');
const botaoFechar2 = document.getElementById('fechar-modal2');

const overlay = document.getElementById('modal-overlay');

// ---------------------- Variaveis para Integracao de Dados (GET/POST) ----------------------
// DOM elements pros inputs do form
const nomeInput = document.getElementById('nome-usuario');
const generoSelect = document.getElementById('genero-usuario');
const descricaoTextarea = document.getElementById('campo-descricao');

// DOM elements pra foto
const fotoUsuarioImg = document.getElementById('foto-usuario');
const inputFotoFile = document.getElementById('input-foto');
const btnEnviarFoto = document.getElementById('enviar-foto-usuario');

// Botoes de acao
const btnSalvarMudancas = document.getElementById('salvar-mudancas');

// Constante pra rota do Controller
const URL_BASE = '/Livro';

// URL base do icone default pra resetar a foto
const FOTO_DEFAULT_URL = 'assets/icons/inserir-foto.svg';
const formElement = document.querySelector('.form-edicao-perfil'); // Pega o form pra poder dar reset

/**
 * Reseta o formulario pra limpar qualquer alteracao nao salva 
 * (Resolvendo o bug de 'salvar' ao fechar/cancelar).
 */
function resetarModal() {
    // Reseta o formulario pros valores originais do GET
    // Se o form fosse um HTML nativo, isso bastaria pra inputs de texto.
    if (formElement) {
        formElement.reset();
    }

    // O reset() nao limpa o preview da imagem, entao a gente tem que resetar na mao.
    // Limpa o input file e volta a imagem pra default.
    fotoUsuarioImg.src = FOTO_DEFAULT_URL;
    inputFotoFile.value = '';
}


// --- Listeners de Abertura ---
botaoAbrir.addEventListener('click', () => {
    // Abre o modal
    modal.classList.add('ativo');
    overlay.classList.add('ativo');

    // Chama a funcao pra puxar os dados do backend e preencher o form
    carregarDadosPerfil();
});


// --- Listeners de Fechamento ---
// O segredo pra corrigir o bug de 'salvar' sem salvar e resetar TUDO
botaoFechar.addEventListener('click', () => {
    modal.classList.remove('ativo');
    overlay.classList.remove('ativo');
    resetarModal(); // <<< CORRIGIDO: Limpa o form ao fechar
});

botaoFechar2.addEventListener('click', () => {
    modal.classList.remove('ativo');
    overlay.classList.remove('ativo');
    resetarModal(); // <<< CORRIGIDO: Limpa o form ao fechar
});

overlay.addEventListener('click', () => {
    modal.classList.remove('ativo');
    overlay.classList.remove('ativo');
    resetarModal(); // <<< CORRIGIDO: Limpa o form ao fechar
});

document.addEventListener('keydown', ESC => {
    if (ESC.key === 'Escape') {
        modal.classList.remove('ativo');
        overlay.classList.remove('ativo');
        resetarModal(); // <<< CORRIGIDO: Limpa o form ao fechar
    }
});


/**
 * GET: Carrega dados do perfil (Nome, Genero, Descricao, FotoURL) do C#
 * Rota: LivroController.BuscarPerfil
 */
function carregarDadosPerfil() {
    fetch(`${URL_BASE}/BuscarPerfil`)
        .then(response => {
            // Se o status nao for 200, cai no catch
            if (!response.ok) {
                throw new Error('Falha na requisicao GET de perfil.');
            }
            return response.json();
        })
        .then(data => {
            // Se nao tiver dados, para por aqui
            if (!data) return;

            // Popula os campos com os dados do banco
            nomeInput.value = data.nome || '';
            descricaoTextarea.value = data.descricaoUsuario || '';
            generoSelect.value = data.generoUsuario || 'Outro';

            // Verifica e exibe a foto (Base64)
            if (data.fotoURL) {
                // Checa se a URL e Base64 (string gigante) ou URL simples
                if (data.fotoURL.length > 500) {
                    fotoUsuarioImg.src = `data:image/jpeg;base64,${data.fotoURL}`;
                } else {
                    fotoUsuarioImg.src = data.fotoURL; // Se for link/caminho simples
                }
            } else {
                fotoUsuarioImg.src = FOTO_DEFAULT_URL; // Se nao tiver foto, usa o default
            }
        })
        .catch(error => {
            console.error('Erro GET no perfil:', error);
            // Avisa o user que nao deu pra carregar os dados
            // alert('Erro ao carregar dados do perfil. Tente novamente.'); 
        });
}


/**
 * Logica pra abrir o file explorer quando clica no botao de 'Fazer upload' 
 * e mostrar o preview da imagem selecionada.
 */
btnEnviarFoto.addEventListener('click', () => {
    inputFotoFile.click();
});

inputFotoFile.addEventListener('change', function (event) {
    const file = event.target.files[0];
    if (file) {
        const reader = new FileReader();
        reader.onload = function (e) {
            fotoUsuarioImg.src = e.target.result;
        };
        reader.readAsDataURL(file);
    }
});


/**
 * POST: Salva as alteracoes (Nome, Genero, Descricao, Foto).
 * Rota: LivroController.AtualizarPerfil
 */
btnSalvarMudancas.addEventListener('click', (event) => {
    event.preventDefault(); // Bloqueia o submit padrao do form

    // FormData e a classe pra mandar dados de formulario, inclusive arquivos (a foto).
    const formData = new FormData();

    // Anexa dados de texto (Tem que bater com os 'Names' do PerfilViewModel no C#)
    formData.append('Nome', nomeInput.value);
    formData.append('GeneroUsuario', generoSelect.value);
    formData.append('DescricaoUsuario', descricaoTextarea.value);

    // Anexa arquivo de foto, se tiver sido selecionado um novo
    const fotoFile = inputFotoFile.files[0];
    if (fotoFile) {
        formData.append('Foto', fotoFile);
    }

    fetch(`${URL_BASE}/AtualizarPerfil`, {
        method: 'POST',
        body: formData // Usa FormData, entao nao precisa de headers de content-type
    })
        .then(response => {
            // CORRIGIDO: O reload so acontece se o POST for 100% OK, garantindo que os dados
            // ja estao no banco antes de recarregar a pagina.
            if (response.ok || response.redirected) {
                alert('Perfil atualizado com sucesso! Recarregando...');

                // Fecha modal
                modal.classList.remove('ativo');
                overlay.classList.remove('ativo');

                // Recarrega a pagina. O proximo GET vai puxar os dados atualizados.
                window.location.reload();
            } else {
                // Se o C# deu erro 500 ou 400, cai aqui
                throw new Error('Falha ao salvar. Status: ' + response.status);
            }
        })
        .catch(error => {
            console.error('Erro POST ao salvar:', error);
            alert('Erro critico ao salvar: ' + error.message + '. Tente de novo.');
        });
});