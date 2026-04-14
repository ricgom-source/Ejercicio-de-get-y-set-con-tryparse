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

                    if(value >= 4 && value <= 100)

                    {

                        edad = value;

                    }

                    else

                    {

                        Console.WriteLine("La edad debe estar entre 4 y 100 años");


                    }



                }



            }

            public int Nota

            {

                get

                {

                    return nota;

                }


                set

                {
                    if(value>=0 && value <= 100)


                    {

                        nota = value;

                    }

                    else

                    {

                        Console.WriteLine("La nota debe estar entre 0 y 100");


                    }



                }




            }

            public string Estado ()

            {
                if(nota>=61)

                {
                    return "Aprobado";

                }

                else

                {

                    return "Reprobado";


                }

            }



        }

        static void Main(string[] args)

        {
            Estudiante e = new Estudiante();

            string nom;

            int ed;

            int not;

            bool correcto;

            do

            {
                Console.ReadKey();

                Console.Clear();

                Console.WriteLine("Ingrese el nombre del estudiante:_ ");

                nom = Console.ReadLine();

                e.Nombre = nom;

            }

            while (nom.Length < 4);

            do

            {
                Console


            }

            











        }
    }
}
