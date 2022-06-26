const automovil={
    marca:'Fiat',
    modelo:'500',
    year:2018,
    color:'red',
    motor:1.0,
    puertas:4,
    marcas:['Fiat','Chevrolet','Ford','Renault'],
    mostrarInformacion:function(){
        console.log(`${this.marca} ${this.modelo} ${this.year}`);
    }

}

for (let prop in automovil){
    console.log(`${prop}: ${automovil[prop]}`);
}

for(let [llave,valor] of Object.entries(automovil)){
    console.log(`${llave}: ${valor}`);
}