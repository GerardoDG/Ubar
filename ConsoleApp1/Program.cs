using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Geolocation;


namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double iniciolatitud, iniciolongitud, finlatitud, finlongitud;


            Console.WriteLine("Bienvenido al sistema de transporte Ubar:");
            Console.WriteLine("Ingrese la latitud donde iniciará el viaje: ");
            iniciolatitud = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la longitud donde iniciará el viaje: ");
            iniciolongitud = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la latitud donde finalizará el viaje: ");
            finlatitud = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la longitud donde finalizará el viaje: ");
            finlongitud = double.Parse(Console.ReadLine());
            horario();
            calculo(iniciolatitud,iniciolongitud,finlatitud,finlongitud);
            Console.ReadLine();


        }

        static void calculo (double num1, double num2, double num3, double num4)
        {
            Coordinate origin = new Coordinate(num1, num2); //Objeto de tipo coordenada donde se indica latitud y longitud
            Coordinate destination = new Coordinate(num3, num4);
            double distance = GeoCalculator.GetDistance(origin, destination, 1);//cálculo de distancia entre los puntos
            string direction = GeoCalculator.GetDirection(origin, destination); //Cálculo de la cardinalidad
            double distanciaenkm = distance * 1.6;
            double tiempoestimado = (distanciaenkm * 60) / 50;
            double costo = (distanciaenkm / 2) * 50;
            Console.WriteLine(distanciaenkm);
            Console.WriteLine(direction);
            Console.WriteLine(tiempoestimado);
            Console.WriteLine(costo);
        }

        static void horario()
        {
            Boolean entro = true;
            Console.WriteLine("¿El horario del viaje es ahora? S/N");
            String letra =  Console.ReadLine();
            do
            {
                switch (letra)
                {
                    case ("N"):
                    case ("n"):
                        Console.WriteLine("Introduce la fecha con el formato año, mes, dia, hora, minuto, segundo");
                        String fecha = Console.ReadLine();
                        break;
                    case ("S"):
                    case ("s"):
                        String datetime = DateTime.Now.ToString("f");
                        Console.WriteLine(datetime);
                        break;
                    default:
                        Console.WriteLine("Ingrese una letra permitida.");
                        entro = false;
                        break;

                }
            } while (entro = !true);
            
        }

        static void asignar(int opc7)
        {
            double hour = opc7;
            DateTime dateValue = new DateTime();
            Console.WriteLine("{0} + {1} = {2}", dateValue, hour, dateValue.AddHours(hour));

            
        }
    }
}
