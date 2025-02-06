
internal class Program
{
    static void Main(string[] args)
    {
        while (true)
        {

            Console.WriteLine("------------------------------------------ ");
            Console.WriteLine("Kujundid ja kalkulatsion ");
            Console.WriteLine("------------------------------------------ ");
            Console.WriteLine("Milleks kujundid soovid?(Ring-1 Ruut-2 Kolmnurk-3 Ristkulik-4) ");
        string figure = Console.ReadLine();



        if (figure == "1")  //крун
        {
            double radius;
            double thickness = 0.4;
            char symbol = '*';

            do
            {
                Console.Write("Enter radius:::");
                    Console.WriteLine("------------------------------------------ ");
                    if (!double.TryParse(Console.ReadLine(), out radius) || radius <= 0)
                {
                    Console.WriteLine("Radius have to be positive number");
                }
            }
            while (radius <= 0);

            Console.WriteLine();
            double rIn = radius - thickness, rOut = radius + thickness;

            for (double y = radius; y >= -radius; --y)
            {
                for (double x = -radius; x < rOut; x += 0.5)
                {
                    double value = x * x + y * y;
                    if (value >= rIn * rIn && value <= rOut * rOut)
                    {
                        Console.Write(symbol);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }

                Console.WriteLine(" ");
            }
                Console.WriteLine("------------------------------------------ ");
                Console.WriteLine("Kas soovite ümbermõõt(1) või pindala(sisesta 2)?");
                Console.WriteLine("------------------------------------------ ");//периметр 2pi r и площадь pi*r2
                string calc = Console.ReadLine();
            const double pi = Math.PI;

            if (calc == "1")
            {
                Console.WriteLine("Ümbermõõt on  "+ 2*pi*radius);
            }
            else if (calc == "2")
            {
                {
                    Console.WriteLine("Pindala on  " +  pi * (radius*radius));
                }
            }
            else
            {
                Console.WriteLine(" error");
            }



        }




        else if (figure == "2")          //квадрат
        {
            Console.WriteLine("Ruudu tegemine");
                Console.WriteLine("------------------------------------------ ");
                Console.WriteLine("Sisesta ruudu suurus");
            int squareSize = Int32.Parse(Console.ReadLine());

            for (int row = 1; row <= squareSize; row++)
            {
                for (int column = 1; column <= squareSize; column++)
                {
                    string variable = (row == column || row + column == squareSize + 1) ? " * " : " * ";

                    Console.Write(variable);
                }

                Console.WriteLine();
            }

            Console.ReadKey();
                Console.WriteLine("------------------------------------------ ");
                Console.WriteLine("Kas soovite ümbermõõt(1) või pindala(sisesta 2)?");
                Console.WriteLine("------------------------------------------ ");
                string calс = Console.ReadLine();
            if (calс == "1")
            {
                Console.WriteLine("Ümbermõõt on  " + squareSize*4 );
            }
            else if (calс == "2")
            {
                {
                    Console.WriteLine("Pindala on  " + squareSize* squareSize);
                }
            }
            else
            {
                Console.WriteLine(" error");
            }


        }









        else if (figure == "3")  //треугольник
        {
            Console.Write("---------------------------");
            Console.Write("\n\n");
            Console.WriteLine("Sisesta kolmnurku suurus");
            int i, j, n;

            n = Convert.ToInt32(Console.ReadLine());

            {
                for (i = 0; i <= n; i++)
            {
                for (j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }
                for (j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
            }
                Console.WriteLine("------------------------------------------ ");
                Console.WriteLine("Kas soovite ümbermõõt(1) või pindala(sisesta 2)?");
                Console.WriteLine("------------------------------------------ ");
                string calс = Console.ReadLine();
            if (calс == "1")
            {
                Console.WriteLine("Ümbermõõt on  " + n*3); 
            }
            else if (calс == "2")
            
                {
                    Console.WriteLine("Pindala on  " + (n*n)/2 );//  a * h \2
                }
            
            else
            {
                Console.WriteLine(" error");
            }
        }








        else if (figure == "4")  //пр\ямоугольник
        {
            {
                Console.WriteLine("Ristkyliku tegemine");
                    Console.WriteLine("------------------------------------------ ");
                    Console.WriteLine("Sisesta Ristkyliku suurus A");
            int SizeA= Int32.Parse(Console.ReadLine());
            Console.WriteLine("Sisesta Ristkyliku suurus B");
            int SizeB = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < SizeA; i++)
            {
                for (int j = 0; j < SizeB; j++)
                {
                   

                    Console.Write(" * ");
                }

                Console.WriteLine();
            }
                    Console.WriteLine("------------------------------------------ ");
                    Console.WriteLine("Kas soovite ümbermõõt(1) või pindala(sisesta 2)?");
                string calс = Console.ReadLine();
                if (calс == "1")
                {
                    Console.WriteLine("Ümbermõõt on  " + (SizeA+SizeB)*2);
                }
                else if (calс == "2")

                {
                    Console.WriteLine("Pindala on  " + SizeA *SizeB);//  a * h \2
                }

                else
                {
                    Console.WriteLine(" error");
                }

            }
    }

        else
        {
            Console.WriteLine("errr");
        }


            Console.WriteLine("------------------------------------------ ");
            Console.WriteLine("KAs soovite sisestada uut kujundit(jah/ei)");
        string choise = Console.ReadLine();
        
        if (choise?.ToLower() !="jah")

        {
            break;
        }

        }

    }

}
