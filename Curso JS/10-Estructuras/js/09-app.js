const autentricado=true;
const puedePagar=true;
console.log(autenticado&&puedePagar?"si esta autenticado":null);


const efectivo=300;
const credito=400;
const disponible=efectivo+credito;
const totalPagar=600;

if (efectivo>=totalPagar || credito>=totalPagar || disponible>=totalPagar) {
    console.log("si podemos pagar");
}
else
{
    console.log("no podemos pagar");
}