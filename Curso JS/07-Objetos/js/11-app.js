const producto = {
    nombre: "monitor de 30 pulgadas",
    precio: 300,
    disponible: true,
    mostrarInfo:function(){
            console.log(`el producto tiene un precio de ${this.precio} `)
    }

}
const producto2 = {
    nombre: "monitor de 30 pulgadas",
    precio: 500,
    disponible: false,
    mostrarInfo:function(){
            console.log(`el producto tiene un precio de ${this.precio} `)
    }

}

console.log(producto);
console.log(producto2);

