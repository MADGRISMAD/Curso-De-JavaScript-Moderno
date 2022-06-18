const carrito=
[
    {nombre:'monitor 27 pulgadas',precio:500},
    {nombre:'monitor 26 pulgadas',precio:300},
    {nombre:'monitor 28 pulgadas',precio:400},
    {nombre:'monitor 24 pulgadas',precio:700},
    {nombre:'monitor 29 pulgadas',precio:600},
    {nombre:'monitor 23 pulgadas',precio:800},
]
for (var i = 0; i <carrito.length; i++) {

    console.log(carrito[i]);
}

carrito.forEach(function(producto){
    console.log(`${producto.nombre}- precio:${producto.precio}`);
})
