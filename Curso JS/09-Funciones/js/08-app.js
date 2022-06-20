function sumar(a,b) {
    return a + b;

}
const result=sumar(3,4);
console.log(result);    

//ejempolo0 mas avanzado

let  total=0;

function agregarCarrito(precio) {
    return total+=precio;

}

function CalcularImpuesto(total){
    return total*1.16;
}
total+agregarCarrito(300);
total+agregarCarrito(400);
total+agregarCarrito(100);
const totalpagar=CalcularImpuesto(total);
console.log("el total a pagar es "+totalpagar);
console.log(total);

