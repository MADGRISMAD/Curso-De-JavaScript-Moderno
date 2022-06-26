for(let i=0; i<=20; i++){
    if(i===5){
        console.log('cinco');
        continue;

    }
    console.log(`numero ${i}`);
}

const carrito=
[
    {nombre:'monitor 27 pulgadas',precio:500},
    {nombre:'monitor 26 pulgadas',precio:300,descuento:true},
    {nombre:'monitor 28 pulgadas',precio:400},
    {nombre:'monitor 24 pulgadas',precio:700},
    {nombre:'monitor 29 pulgadas',precio:600},
    {nombre:'monitor 23 pulgadas',precio:800},
]

for (let i = 0; i <carrito.length; i++) {
    if(carrito[i].descuento){
        console.log(`${carrito[i].nombre} tiene descuento`);
    }
    
}