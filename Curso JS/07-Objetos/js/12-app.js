//object literal
const producto = {
    nombre: "monitor de 30 pulgadas",
    precio: 300,
    disponible: true,   
}
///object constructor

function Producto(nombre, precio) {
    this.nombre = nombre;
    this.precio = precio;
    this.disponible = true;

}
const producto2=new Producto("monitor de 24 pulgas",300);

console.log(producto2);



