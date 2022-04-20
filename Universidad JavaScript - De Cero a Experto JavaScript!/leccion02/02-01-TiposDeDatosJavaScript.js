//tipo de dato string
var nombre="madeline";
console.log(typeof nombre);
nombre=10;
console.log(nombre);
//dato numerico
var numero=5;
console.log(typeof numero);

//objeto
var objeto={
    nombre:"juan", 
    appellido:"perez",
    telefono:"324598"
}
console.log(typeof objeto);
//boolean

var bandera=false;
console.log(typeof bandera)

//funcion

function mifuncion(){

}

console.log(typeof mifuncion);

//symbol

var simbolo=Symbol("mi simbolo");
console.log(typeof simbolo)

//clase es una funcion

class persona{
    constructor(nombre, apellido){
        this.nombre=nombre;
        this.apellido=apellido;
    }
}

console.log(typeof persona)

//indefinido 

var x;
console.log(typeof x)

x=undefined;

console.log(x);

//null o vacio

var y=null;
console.log(typeof y);
/* */
var autos=['BMW','AUDI','VOLVO'];
console.log(typeof autos);
console.log(autos);
/* */
var z='';
console.log(z);
console.log(typeof z);
/**/


