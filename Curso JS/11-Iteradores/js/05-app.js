let i=0; //incio
do{
    if (i % 3 === 0 && i % 5 === 0) {
        console.log('fizzbuzz');
    }
    else if (i % 3 === 0) {
        console.log('fizz');
    }
    else if (i % 5 === 0) {
        console.log('buzz');
    }
    else {
        console.log(i);
    }

    i++; //incremento
}while(i<=100); //condicion
// console.log(i); //fin
