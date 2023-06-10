using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuplas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HOLA MUNDO SOY UN PROGRAMADOR  EN C# Y EXPERTO EN REDES EXCELENTE");


            string nombre = "LARRYSALSA";
            byte dia = 6;
            long celular = 3188576678;
            int dir = 123456;

            //(tipo) Identificador= (valor);
            // una tupla Una tupla es una secuencia de valores agrupados.

            //Una tupla sirve para agrupar, como si fueran un único valor, varios valores que, por su naturaleza, deben ir juntos.

            //(string, byte, long, int) persona1 = ("LARRYSALSA", 6, 3188576678, 123456);

            var persona1 = (nombre: "LARRYSALSA", dia: 6, celular: 3188576678, direccion: 123456);


            // Console.WriteLine(persona1);

            //Console.WriteLine("{0}, {1}, {2}", nombre, dia, celular);

            //Console.WriteLine(persona1.Item3);

            Console.WriteLine(persona1.celular);












        }
    }
}
