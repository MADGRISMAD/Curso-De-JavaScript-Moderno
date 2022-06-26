//for each
const pendientes=['Tarea 1','Tarea 2','Tarea 3'];
pendientes.forEach(pendientes,indice=>{console.log(`${indice}`)});

const carrito=
[
    {nombre:'monitor 27 pulgadas',precio:500},
    {nombre:'monitor 26 pulgadas',precio:300},
    {nombre:'monitor 28 pulgadas',precio:400},
    {nombre:'monitor 24 pulgadas',precio:700},
    {nombre:'monitor 29 pulgadas',precio:600},
    {nombre:'monitor 23 pulgadas',precio:800},
]
carrito.forEach(producto=>{console.log(`${producto.nombre}- precio:${producto.precio}`)});

//map
const nuevoArreglo= carrito.map(producto=>{return`${producto.nombre}- precio:${producto.precio}`}
);
console.log(nuevoArreglo);
