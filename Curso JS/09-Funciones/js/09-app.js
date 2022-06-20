const reproductor={
    reproducir:function(id){
        console.log("reproduciendo cancion "+id);
    },
    pausar:function(id){
        console.log("pausando "+id);
    },
    crearplaylist:function(nombre){
        console.log("crear playlist "+nombre);
    },
    reproducirPlaylist:function(nombre){
        console.log("reproduciendo playlist "+nombre);
    }
}

reproductor.reproducir(30);
reproductor.pausar(30);

reproductor.borrar=function(){
    console.log("borrar ");

}
reproductor.borrar();
reproductor.crearplaylist("heavy metal");
reproductor.crearplaylist("rock 90s'");
reproductor.reproducirPlaylist("heavy metal");