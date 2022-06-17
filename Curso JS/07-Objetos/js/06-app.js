const producto = {
    nombre: "monitor de 30 pulgadas",
    precio: 300,
    disponible: true,
    informacion:
    {
        medidas:
        {
            peso: '1 kg',
            medida:'1 mt'
        },
        fabricacion:
        {
            pais:"china"
        }
    }
}
//se pone las llaves para acceder a un nivel mas profundo del objeto
const {nombre,informacion:{fabricacion:{pais}}}=producto;

console.log(nombre);
console.log(pais);

