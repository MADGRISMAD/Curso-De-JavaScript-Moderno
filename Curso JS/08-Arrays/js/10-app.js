const carrito=
[
    {nombre:'monitor 27 pulgadas',precio:500},
    {nombre:'monitor 26 pulgadas',precio:300},
    {nombre:'monitor 28 pulgadas',precio:400},
    {nombre:'monitor 24 pulgadas',precio:700},
    {nombre:'monitor 29 pulgadas',precio:600},
    {nombre:'monitor 23 pulgadas',precio:800},
]

const nuevoArreglo= carrito.forEach(function(producto){
   return`${producto.nombre}- precio:${producto.precio}`;
})

const nuevoArreglo2= carrito.map(function(producto){
    return`${producto.nombre}-- precio:${producto.precio}`;
})

console.log(nuevoArreglo2); 
console.log(nuevoArreglo);

