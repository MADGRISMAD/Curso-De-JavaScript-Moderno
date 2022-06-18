const producto={
    nombre:'monitor de 20 pulgadas',
    precio:300,
    disponible:true
}

const {nombre}=producto;
console.log(nombre);

//distrocturing con arreglos
const numeros=[10,20,30,40,50,60,];
const[,,tercero]=numeros;
//const [primero,segundo,tercero]=numeros;

console .log(tercero);