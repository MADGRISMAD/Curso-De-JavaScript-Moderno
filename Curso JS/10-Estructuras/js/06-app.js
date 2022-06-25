const usuario = true;
const puedePagar = true;

if (usuario && puedePagar) {
  console.log("si puedes comprar");
} else if (!puedePagar) {
  console.log("necesitas usuario");
} else if (!usuario) {
  console.log("necesitas tarjeta");
} else {
  console.log("no puedes comprar");
}

