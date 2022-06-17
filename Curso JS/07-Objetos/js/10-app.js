const producto = {
    nombre: "monitor de 30 pulgadas",
    precio: 300,
    disponible: true

}

const medidas={
    peso:"1 kg",
    medidas: "1 mt"
}

console.log(producto);
console.log(medidas);

const resultado=Object.assign(producto, medidas);

//spread operator o rest operator

const resultado2={...producto,...medidas};
console.log(resultado);
console.log(resultado2);