const reproductor={
    cancion:'',
    reproducir:id =>console.log("reproduciendo cancion "+id),

    pausar:id =>console.log("pausando "+id),
    
    crearplaylist:nombre =>console.log("crear playlist "+nombre),
    
    reproducirPlaylist:nombre =>console.log("reproduciendo playlist "+nombre),
    
    set nuevaCancion(cancion)
    {
        this.cancion = cancion;
        console.log("cancion "+cancion+" anadida");
    },
    get obtenerCancion(){
        console.log(`${this.cancion}`)
    }
}
reproductor.nuevaCancion="hola amigo";
reproductor.obtenerCancion;

reproductor.reproducir(30);
reproductor.pausar(30);

reproductor.borrar=function(){
    console.log("borrar ");

}
reproductor.borrar();
reproductor.crearplaylist("heavy metal");
reproductor.crearplaylist("rock 90s'");
reproductor.reproducirPlaylist("heavy metal");