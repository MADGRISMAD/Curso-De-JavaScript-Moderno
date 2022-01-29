using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avion
{
    public interface Ivehiculo
    {
        double Acelerar();


        double frenar();
    }
    public abstract class AVeiculo:Ivehiculo
    {
        protected double tiempo;
        protected double velocidad;
        protected double nivel;
        
        
        public  double Acelerar()
        {
            return velocidad * tiempo;
        }
        public  double Frenar()
        {
            return velocidad * 0;
        }
        public abstract void CargarGasolina(double nivel);
        public abstract void Mirar(double velocidad, double nivel, double tiempo);


        public virtual string Ver()
        {
            return "\nvelocidad      " + velocidad +
                   "\naceleracion    " + Acelerar() +
                   "\nnivel de gas   " + nivel;
        }
        public abstract double Velocidad();
        public abstract double Nivel();

        public double frenar()
        {
            throw new NotImplementedException();
        }
    }


    public class Automovil : AVeiculo, Ivehiculo
    {
        public override void Mirar(double velocidad, double nivel, double tiempo)
        {
            this.velocidad = velocidad;
            this.nivel = nivel;
            this.tiempo = tiempo;
        }
        public override void CargarGasolina(double nivel)
        {
            throw new NotImplementedException();
        }

        public new double Frenar()
        {
            throw new NotImplementedException();
            
        }
        

        public override string Ver()
        {
            return "\nvelocidad      " + velocidad +
                   "\naceleracion    " + Acelerar() +
                   "\nnivel de gas   " + nivel;
        }
        public override double Velocidad()
        {
            return velocidad;
        }
        public override double Nivel()
        {
            return nivel;
        }


    }



    public class Automovil<Clase>
    {
        protected int posicion;
        protected int maximo;
        protected Clase[] lista;
        public Automovil(int numElementos)
        {
            maximo = numElementos;
            posicion = 0;
            lista = new Clase[maximo];
        }
        public Boolean Agregar(Clase objeto)
        {
            if (posicion < maximo)
            {
                lista[posicion++] = objeto;
                return true;
            }
            return false;
        }
        public Clase Obtiene(int posicion)
        {
            return lista[posicion];
        }
        


    }

    class Program
    {

        static void Main(string[] args)
        {
            Automovil carro = new Automovil();
            carro.Mirar(100, 100, 5);
            Console.ReadLine();
            
            

        }
    }
}
