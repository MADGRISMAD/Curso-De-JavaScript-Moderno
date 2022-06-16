const producto="monitor 20 pulgadas";

//.repeat te permite repetir una cadena de texto

const texto="en promocion".repeat(3);

console.log(texto);
console.log(`${producto} ${texto} !!!`);

//split te permite diviri una cadena de texto

const actividad="estoy aprendiendo javascript moderno";

console.log(actividad.split(" "));
const hobbie="jamon cebolla tocino tomate";
console.log(hobbie.split(" "));

const tuit="aprendiendo javascript moderno #java";
console.log(tuit.split("#"));