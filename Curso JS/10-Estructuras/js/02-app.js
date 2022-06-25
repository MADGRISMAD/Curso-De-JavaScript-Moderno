const puntaje=1000;
const puntaje2='2000';


console.log(typeof puntaje);
console.log(typeof puntaje2);

if(puntaje!=1000){
    console.log("si es difeerente"); //!= es diferente == es igual
}

if(puntaje  === '1000'){    
    console.log("si es igual");
}
else{    
    console.log("no es igual");
}
//== operador que no es estricto
//=== es estricto