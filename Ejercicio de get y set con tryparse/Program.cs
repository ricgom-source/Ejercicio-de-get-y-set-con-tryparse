using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_de_get_y_set_con_tryparse
{
    internal class Program

    {
        class Estudiante

        {
            private string nombre;

            private int edad;

            private int nota;

            public string Nombre

            {
                get

                {
                    return nombre;

                }

                set

                {
                    if (value.Length >= 4)

                    {

                        nombre = value;

                    }

                    else

                    {

                        Console.WriteLine("El nombre debe de tener al menos 4 carácteres");

                    }



                }


            }

            public int Edad

            {
               get

                {

                    return edad;

                }


                set

                {



                }



            }



        }

















        static void Main(string[] args)

        {












        }
    }
}
