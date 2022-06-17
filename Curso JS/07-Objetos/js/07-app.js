const producto = {
    nombre: "monitor de 30 pulgadas",
    precio: 300,
    disponible: true

}

producto.disponible = false;

delete producto.precio;

console.log(producto);
