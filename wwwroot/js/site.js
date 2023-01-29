var nome = document.getElementById('nome');
var email = document.getElementById('email');
var descricao = document.getElementById('descricao');
var formularioContato = document.getElementById('contatoForm');


var imagemcentro = document.getElementById('centro');
imagemcentro.addEventListener('click', ()=>{
    alert('SEJA BEM VINDO')
})
formularioContato.onsubmit(event =>{
    event.preventDefault();
    if(nome.value === ''){
        alert('Preencha o campo')
        return
    }
    if(email.value === ''){
        alert('Preencha o campo')
        return
    }
    if(descricao.value === ''){
        alert('Preencha o campo')
        return
    }
})