using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace checador
{
     class DatosDelTrabajador
    {
        public int _notrabajador;
        public int _nombre;
        public Double _horastrabajadas;
        public DateTime _horadeacceso;
        public DateTime _horadesalida;

        public  DatosDelTrabajador(int notrabajador, int nombre, double horastrabajadas,DateTime horadeacceso,DateTime horadesalida)
        {
            this._notrabajador = notrabajador;
            this._nombre = nombre;
            this._horastrabajadas = horastrabajadas;
            this._horadeacceso = horadeacceso;
            this._horadesalida = horadesalida;
        }

        public int notrabajador
        {
            get => notrabajador;
                set => notrabajador = value;
        }
        public int nombre
        {
            get => nombre;
            set => nombre = value;
        }
        public double horastrabajadas
        {
            get => horastrabajadas;
            set => horastrabajadas = value;
        }
        public DateTime horadeacceso
        {
            get => horadeacceso;
            set
            {
                horadeacceso = DateTime.Now;
            }
        }
        public DateTime horadesalida
        {
            get => horadesalida;
            set 
            {
                horadesalida = DateTime.Now;
            }

        }

        public override string ToString()
        {
            return "tus datos son\nnumero de trabajador       :" + notrabajador +
                                "\nnombre del trabajador      :" + nombre +
                                "\nhoras trabajadas tototales :" + horastrabajadas +
                                "\nhora de entrada de hoy     :" + horadeacceso +
                                "\nhora de salida de hoyv     :" + horadesalida;
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            DatosDelTrabajador trabajador1 = new DatosDelTrabajador(1,"manuel",12,datetime.now,);
            
        }
    }
}
