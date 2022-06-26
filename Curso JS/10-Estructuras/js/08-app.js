const autenticado=true;
if(autenticado){
    console.log('el usuario esta autenticado');
}

const puntaje=450;

function revisarPuntaje(){
    if (puntaje>400) {
        console.log('excelente');
        return;
    }
    else if (puntaje>300) {
        console.log('muy bien');
        return;
    }
}
revisarPuntaje();






