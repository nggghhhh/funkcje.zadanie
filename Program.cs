using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUNKCJE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inp = Console.ReadLine();

            if (inp == "1")

            {

                PoleKwadratu();

            }//1


            else if (inp == "2")

            {

                PoleProstokota();

            }//2


            else if (inp == "3")

            {

                Console.WriteLine("podaj promień");

                double a3 = double.Parse(Console.ReadLine());

                PoleKola(a3);

            }//3


            else if (inp == "4")

            {

                Console.WriteLine("podaj bok i wysokość");

                double a4 = double.Parse(Console.ReadLine());
                double h4 = double.Parse(Console.ReadLine());

                PoleTrojkata(a4, h4);

            }//4


            else if (inp == "5")

            {

                PoleRownolegloboku();

            }//5


            else if (inp == "6")

            {

                PoleRombu();

            }//6


            else if (inp == "7")

            {

                PoleTrapezu();

            }//7


            else if (inp == "8")

            {

                ObwodKola();

            }//8


            else if (inp == "9")

            {

                ObwodKwadratu();

            }//9


            else if (inp == "10")

            {

                ObwodProstokata();

            }//10


            else if (inp == "11")

            {

                ObwodRombu();

            }//11


            else if (inp == "12")

            {

                ObwodRownolegloboku();

            }//12


            else if (inp == "13")

            {

                ObwodTrojkataRownobocznego();

            }//13


            else if (inp == "14")

            {

                Console.WriteLine("podaj bok");

                double a15 = double.Parse(Console.ReadLine());

                ObjetoscSzescianu(a15);

            }//14


            else if (inp == "15")

            {

                Console.WriteLine("podaj wysokość i oba boki podstaw");

                double h17 = double.Parse(Console.ReadLine());

                double a17 = double.Parse(Console.ReadLine());

                double b17 = double.Parse(Console.ReadLine());

                ObjetoscProstopadloscianu(h17, a17, b17);

            }//15


            else if (inp == "16")

            {

                Console.WriteLine("podaj 3 boki");

                double a16 = double.Parse(Console.ReadLine());

                double b16 = double.Parse(Console.ReadLine());

                double c16 = double.Parse(Console.ReadLine());

                PoleProstopadloscianu(a16, b16, c16);

            }//16



            else if (inp == "17")

            {

                Console.WriteLine("podaj wysokość i oba boki podstaw");

                double h17 = double.Parse(Console.ReadLine());

                double a17 = double.Parse(Console.ReadLine());

                double b17 = double.Parse(Console.ReadLine());

                ObjetoscProstopadloscianu(h17, a17, b17);

            }//17


            else if (inp == "18")

            {

                Console.WriteLine("podaj pole podstawy i pole całkowite boków");

                double Pp18 = double.Parse(Console.ReadLine());

                double Pb18 = double.Parse(Console.ReadLine());

                PoleGraniastoslupa(Pp18, Pb18);

            }//18


            else if (inp == "19")

            {

                Console.WriteLine("podaj promień");

                double r19 = double.Parse(Console.ReadLine());



                objetosckuli(r19);

            }//19


            else if (inp == "20")

            {

                PoleOstroslupa();

            }//20


            else if (inp == "21")

            {

                ObjetoscOstroslupa();

            }//21



            else if (inp == "22")

            {

                EnergiaPotencjalna();

            }//22


            else if (inp == "23")

            {

                SilaGrawitacji();

            }//23


            else if (inp == "24")

            {

                Droga();

            }//24


            else if (inp == "25")

            {

                Przyspieszenie();

            }//25


            else

            {

                Console.WriteLine("Brak wzoru");

            }


            Console.ReadKey();



        }
        public static void PoleKwadratu()

        {

            Console.WriteLine("podaj bok");

            int a1 = int.Parse(Console.ReadLine());

            Console.WriteLine(a1 * a1);

        }//1


        public static int PoleProstokota()

        {

            Console.WriteLine("podaj boki");

            int a2 = int.Parse(Console.ReadLine());
            int b2 = int.Parse(Console.ReadLine());

            int wynik1 = a2 * b2;

            return wynik1;

        }//2


        public static double PoleKola(double a3)

        {

            double wynik3 = Math.Pow(a3, 2) * Math.PI;

            return wynik3;

        }//3


        public static double PoleTrojkata(double a4, double h4)

        {

            return a4 * h4 / 2;

        }//4


        public static void PoleRownolegloboku()

        {

            Console.WriteLine("podaj wysokość i podstawę a i h");

            int h6 = int.Parse(Console.ReadLine());

            int a6 = int.Parse(Console.ReadLine());

            Console.WriteLine(h6 * a6);



        }//5


        public static void PoleRombu()

        {

            Console.WriteLine("podaj wysokość i podstawę");

            int h7 = int.Parse(Console.ReadLine());

            int a7 = int.Parse(Console.ReadLine());

            Console.WriteLine(h7 * a7);

        }//6


        public static void PoleTrapezu()

        {

            Console.WriteLine("podaj obie podstawy i wysokość");

            int a8 = int.Parse(Console.ReadLine());

            int b8 = int.Parse(Console.ReadLine());

            int h8 = int.Parse(Console.ReadLine());

            int wynik8 = ((a8 + b8) * h8) / 2;

            Console.WriteLine(wynik8);

        }//7


        public static void ObwodKwadratu()

        {

            Console.WriteLine("podaj bok");

            int a = int.Parse(Console.ReadLine());



            Console.WriteLine(a * 4);

        }//8


        public static void ObwodKola()

        {

            Console.WriteLine("podaj promień");

            int r = int.Parse(Console.ReadLine());



            Console.WriteLine(2 * Math.PI * r);

        }//9

        public static void ObwodProstokata()

        {

            Console.WriteLine("podaj boki");

            int a10 = int.Parse(Console.ReadLine());

            int b10 = int.Parse(Console.ReadLine());

            Console.WriteLine(2 * a10 + 2 * b10);

        }//10


        public static void ObwodRombu()

        {

            Console.WriteLine("podaj bok");

            int a11 = int.Parse(Console.ReadLine());

            Console.WriteLine(a11 * 4);

        }//11


        public static void ObwodRownolegloboku()

        {

            Console.WriteLine("Podaj boki a i b");

            int a12 = int.Parse(Console.ReadLine());

            int b12 = int.Parse(Console.ReadLine());

            Console.WriteLine(a12 * 2 + b12 * 2);


        }//12


        public static void ObwodTrojkataRownobocznego()

        {

            Console.WriteLine("podaj bok");

            int a13 = int.Parse(Console.ReadLine());

            Console.WriteLine(a13 * 3);

        }//13


        public static double ObjetoscSzescianu(double a15)

        {

            return Math.Pow(a15, 3);
            
        }//14


        public static double ObjetoscProstopadloscianu(double a17, double b17, double c17)

        {

            return c17 * a17 * b17;

        }//15


        public static double PoleProstopadloscianu(double h16, double a16, double b16)

        {

            double wynik16 = 2 * (a16 * b16 + b16 * h16 + a16 * h16);

            return (wynik16);

        }//16


        public static double ObjetoscGraniastoslupa(double Pp19, double H19)

        {

            return Pp19 * H19;

        }//17


        public static double PoleGraniastoslupa(double Pp18, double Pb18)

        {

            return 2 * Pp18 + Pb18;

        }//18


        public static double objetosckuli(double r19)

        {

            return Math.PI * r19 * r19 * r19 * 4 / 3;

        }//19


        public static double PoleOstroslupa()

        {

            Console.WriteLine("podaj pole podstawy i pole boków");

            double Pp20 = double.Parse(Console.ReadLine());

            double Pb20 = double.Parse(Console.ReadLine());

            return Pp20 + Pb20;

        }//20


        public static double ObjetoscOstroslupa()

        {

            Console.WriteLine("podaj pole podstawy i wysokość");

            double Pp21 = double.Parse(Console.ReadLine());

            double H21 = double.Parse(Console.ReadLine());

            return (Pp21 / 3) * H21;

        }//21


        public static double EnergiaPotencjalna()

        {

            Console.WriteLine("podaj mase i wysokosc");

            double m22 = double.Parse(Console.ReadLine());

            double h22 = double.Parse(Console.ReadLine());

            return m22 * h22 * 9.81;

        }//22


        public static double SilaGrawitacji()

        {

            Console.WriteLine("podaj mase");

            double m23 = double.Parse(Console.ReadLine());

            return m23 * 9.81;

        }//23


        public static double Droga()

        {

            Console.WriteLine("podaj predkosc i czas");

            double v24 = double.Parse(Console.ReadLine());

            double t24 = double.Parse(Console.ReadLine());

            return v24 * t24;

        }//24


        public static double Przyspieszenie()

        {

            Console.WriteLine("podaj predkosc i czas");

            double v25 = double.Parse(Console.ReadLine());

            double t25 = double.Parse(Console.ReadLine());

            return v25 / t25;

        }//25
    }
}
