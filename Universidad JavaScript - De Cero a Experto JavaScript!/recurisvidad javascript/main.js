var txt1;
txt1=parseInt(prompt("por favor ingresa el numero:"));

function factorial(i)
{
    if (i==0)
        return 1;
    else
        return i * factorial(i-1);
}
console.log("el numero de factoriale recursivos fue de",txt1,"es:" ,factorial(txt1));