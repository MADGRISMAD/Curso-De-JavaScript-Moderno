
const meses = ['Enero', 'Febrero', 'Marzo'];


meses.push("abril");
meses.push("mayo");
console.table(meses);

const carrito=[];

//definir un producto
const producto = {

    nombre:'monitor de 32 pulgadas',
    precio:500,

}
const producto2 = {

    nombre:'celular',
    precio:800,

}
const producto3 = {

    nombre:'teclado',
    precio:800,

}
const producto4 = {

    nombre:'celular 2',
    precio:800,

}


carrito.push(producto);
carrito.push(producto2);
carrito.push(producto4);
carrito.unshift(producto3);
console.table(carrito);


//eliminar ultimo elemento de un arreglo
//carrito.pop();
//console.table(carrito);
//eliminar del inicio del arreglo
//carrito.shift();
//console.table(carrito);

carrito.splice(0,1);
console .table(carrito);

