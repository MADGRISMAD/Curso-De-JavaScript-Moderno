

for(let i=0; i<=20; i++){
    console.log(`numero ${i}`);
}

//identify the odd numbers from 1 to 200
for(let i=0; i<=20; i++){
    if(i%2==0){
        console.log(`numero par ${i}`);
    }
    else{
        console.log(`numero impar ${i}`);
    }
}
const carrito=
[
    {nombre:'monitor 27 pulgadas',precio:500},
    {nombre:'monitor 26 pulgadas',precio:300},
    {nombre:'monitor 28 pulgadas',precio:400},
    {nombre:'monitor 24 pulgadas',precio:700},
    {nombre:'monitor 29 pulgadas',precio:600},
    {nombre:'monitor 23 pulgadas',precio:800},
]
for (let i = 0; i <carrito.length; i++) {
    console.log(carrito[i].nombre);
}
