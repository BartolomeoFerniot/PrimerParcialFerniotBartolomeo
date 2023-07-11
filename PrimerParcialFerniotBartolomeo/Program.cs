using System.Buffers.Text;

namespace PrimerParcialFerniotBartolomeo
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Double radio;
            Double altura;
            Double area;
            Double basee;
            Double volumen;
            Double seguir;
            bool verseguir;
            verseguir = true;

            while (verseguir = true) 
            {
                Console.Write("Informe el radio del cilindro: ");
                radio = Double.Parse(Console.ReadLine());




                if (Validarpositivo(radio))
                {
                    Console.Write("Informe la altura del cilindro: ");
                    altura = Double.Parse(Console.ReadLine());

                    if (Validarpositivo(altura))
                    {
                        area = calcularArea(radio, altura);
                        basee = calcularBasee(radio);
                        volumen = calcularVolumen(basee, altura);


                        Console.WriteLine($"El àrea del cilindro es: {area}");
                        Console.WriteLine($"El volumen del cilindro es: {volumen}");
                        Console.WriteLine("Si desea ingresar otro cilindro ingrese el nùmero 1, de lo contrario ingrese cualquier otro nùmero");
                        seguir = double.Parse(Console.ReadLine());
                        if (!(seguir == 1))
                        {
                            verseguir = false;
                        }




                        else
                        {
                            Console.WriteLine("No se pueden ingresar valores nulos o negativos");
                        }


                    }
                    else
                    {
                        Console.WriteLine("No se pueden ingresar valores nulos o negativos");
                    }
                }
               


                Console.ReadLine();

                static bool Validarpositivo(double dato)
                {
                    if (dato > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }


            };

         static double calcularVolumen(double basee, double altura)
         {
            return basee * altura;
         }

         static double calcularBasee(double radio)
         {
            return Math.PI * Math.Pow(radio, 2);
         }

         static double calcularArea(double radio, double altura)
          {
            return 2 * Math.PI * radio * (altura + radio);
         }
        }
    }
}