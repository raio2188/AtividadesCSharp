document.querySelectorAll('.olho').forEach(button => {
    const input = button.previousElementSibling;
    button.hidden = false;
    button.setAttribute('aria-controls', input.id);
    button.addEventListener('click', () => {
        const mostrar = input.type === 'password';
        input.type = mostrar ? 'text' : 'password';
        button.setAttribute('aria-pressed', String(mostrar));
    });
});

const senha = document.querySelector('#Senha');
const confirmacao = document.querySelector('#Confirmacao');
if (confirmacao) {
    const validar = () => confirmacao.setCustomValidity(
        confirmacao.value && confirmacao.value !== senha.value ? 'As senhas precisam ser iguais.' : ''
    );
    senha.addEventListener('input', validar);
    confirmacao.addEventListener('input', validar);
}
