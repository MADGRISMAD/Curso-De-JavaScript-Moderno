"use strict";
const producto = {
    nombre: "monitor de 30 pulgadas",
    precio: 300,
    disponible: true

}
//esta linea permite que el objeto se quede congelado para no poder ser modificado en el futuro 
Object.freeze(producto);

//producto.disponible=false;
//producto.imgen ="imagen.jpg";
console.log(producto);

console.log(Object.isFrozen(producto));


