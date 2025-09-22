using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("///////TABLA DE CAERRARAS////////");
            Console.WriteLine("ESCOGA EL NUMERO DE CARRERAS DEL 1 AL 14");
            Console.WriteLine("1)(MEDICINA, MEDICINA, 22,500,00");
            Console.WriteLine("2)(MEDICINA, ENFERMERIA, 15,300.00");
            Console.WriteLine("3)(MEDICINA, PSICOLOGIA,  12,000.00");
            Console.WriteLine("4)(MEDICINA, NUTRICION, 10,000.00");
            Console.WriteLine("5)(INGERIERIA, ELECTRONICA, 17,000.00");
            Console.WriteLine("6)(INGENIERIA, SISTEMAS, 17,500.00");
            Console.WriteLine("7)(INGENIERIA, INDUSTRIAL, 17,000.00");
            Console.WriteLine("8)(INGENIERIA, MECATRONICA, 20,300.00");
            Console.WriteLine("9)(NEGOCIOS, ADMINISTRACION, 13,500.00");
            Console.WriteLine("10)(NEGOCIOS, CONTABILIDAD, 14,000.00");
            Console.WriteLine("11)(NEGOCIOS, MARKETING, 16,700.00");
            Console.WriteLine("12)(EDUCACION - INICIAL, 10,000.00");
            Console.WriteLine("13)(EDUCACION - PRIMARIA, 12,000.00");
            Console.WriteLine("14)(EDUCACION - SECUNDARIA, 12,000.00");
            int opcion = Convert.ToInt32(Console.ReadLine());

            //DATOS INGRESADOS
            string carrera = "";
            string facultad = "";
            double costoCiclo = 0;            
            //PROCESOS
            switch (opcion)
            {
                case 1: facultad = MEDICINA = carrera = MEDICINA: break;
                case 2: facultad: MEDICNA = carrera: ENFERMERIA: break;
                case 3: facultad: MEDICINA = carrera: PSICIOLOGIA: break;
                case 4: facultad: MEDICINA = carrera: NUTRICION: break;
                case 5: facultad: INGENIERIA = carrera: ELECTRONICA: break;
                case 6: facultad: INGENIERIA = carrera: SISTEMAS: break;
                case 7: facultad: INDUSTRIAL = carrera: INDUSTRIAL: break;
                case 8: facultad: NEGOCIOS = carrera: ADMINISTRACION: break;
            }
                


        }
    }
}
