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


carrito.push(producto);
carrito.push(producto2);
carrito.unshift(producto3);
console.log(carrito);




