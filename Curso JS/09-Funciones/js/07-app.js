iniciarApp();

function iniciarApp() {
    console.log("Iniciando App...");
    segundaFuncion();
}

function segundaFuncion() {
    console.log("Segunda Funcion...");
    usuarioAutenticado("madeline"); //
}

function usuarioAutenticado(usuario) {
    console.log("Usuario Autenticado...espere");
    console.log(`Usuario Autenticado existosamente... ${usuario}`);
}