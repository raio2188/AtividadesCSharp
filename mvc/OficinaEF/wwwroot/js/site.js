document.querySelectorAll('.alert .fechar').forEach(button => {
    button.hidden = false;
    button.addEventListener('click', () => {
        button.closest('.alert').remove();
        document.getElementById('conteudo').focus();
    });
});
