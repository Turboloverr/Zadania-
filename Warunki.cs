# Zadania-using System;

namespace Zadania___warunki
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //zadanie 1
            Console.Write("ZADANIE 1.");
            Console.WriteLine();

            int a = 5;
            int b = 5;

            if (a == b) 
            {
                Console.WriteLine("5 i 5 są równe");
            }
            else
            {
                Console.WriteLine("Liczby nie są równe.");
            }


            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Zadanie 2.");
            Console.WriteLine();


            int c = 4;
            if(c%2==0)
            {
                Console.WriteLine("Liczba jest parzysta");
            }
            else
            {
                Console.WriteLine("Liczba jest niemaprzysta");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Zadanie 3.");

            int d = 14;
            if (d>0 )
            {
                Console.WriteLine("Liczba jest dodatnia");
            }
            else if (d<0)
            {
                Console.WriteLine("Liczba jest ujemna");
            }
            else
            {
                Console.WriteLine("Liczba jest równa zero");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Zadanie 4.");

            int e = 2016;
            if(e%4==0)
            {
                Console.WriteLine("Rok przestępny");
            }
            else
            {
                Console.WriteLine("Rok nieprzestępny");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Zadanie 5.");

            int f = 33;
            if (f >= 21)
            {
                Console.WriteLine("Może zostać posłem");
            }
            else if (f >= 30)
            {

                Console.WriteLine("Może zostać posłem lub premierem");
                
            }
            else if (f>=33)
            {
                Console.WriteLine("Może zostać posłem, premierem lub senatorem");
            }
            else if(f>=35)
            {
                Console.WriteLine("Może zostać posłem, premierem, senatorem lub prezydentem");
            }
            else
            {
                Console.WriteLine("Zbyt młody kandydat :)");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Zadanie 6.");
            Console.WriteLine();

            Console.WriteLine("Podaj swój wzrost w cm: ");
            string wzrost = Console.ReadLine();

            int wzrostt = 0;

            Int32.TryParse(wzrost, out wzrostt);

            if(wzrostt <= 140) 
            {
                Console.WriteLine("JESTES KRASNOLUDEM");
            }
            else
            {
                Console.WriteLine("Jesteś wyższy niż Makłowicz");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Zadanie 7.");

            Console.WriteLine("Podaj pierwszą liczbę: ");
            string pierwsza= Console.ReadLine();
            int z = 0;
            int.TryParse(pierwsza, out z);
            Console.WriteLine("Podaj drugą liczbę");
            string druga = Console.ReadLine();
            int x = 0;
            Int32.TryParse(druga, out x);
            Console.WriteLine("Podaj trzecią liczbę");
            string trzecia = Console.ReadLine();
            int y = 0;
            Int32.TryParse(trzecia, out y);

            if(z>x&& z>y)
            {
                Console.WriteLine($"najwieksza liczba to {z}");
            }
            else if (x>z && x>y)
            {
                Console.WriteLine($"najwieksza liczba to {x}");
            }
            else if (y > z && y > x)
            {
                Console.WriteLine($"najwieksza liczba to {y}");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Zadanie 8.");
            Console.WriteLine();

            int matma = 80;
            int fiza = 71;
            int chemia = 0;
            int suma = matma+fiza+chemia;

            if(suma>=180||matma+fiza>=150||fiza+chemia>=150||matma+chemia>=150)
            {
                Console.WriteLine("Kandydat dopuszczony do rekrutacji");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Zadanie 9.");

            Console.WriteLine("Podaj stopni jest dziś na dworze");
            string temperatura = Console.ReadLine();
            int temp = 0;
            Int32.TryParse(temperatura, out temp);

            if(temp<0)
            {
                Console.WriteLine("Cholernie piździ");
            }
            else if (temp>0&&temp<10)
            {
                Console.WriteLine("zimno");
            }
            else if(temp>=10 && temp<20)
            {
                Console.WriteLine("Chłodno");
            }
            else if(temp>=20 && temp<30)
            {
                Console.WriteLine("W sam raz");
            }
            else if(temp >=30 && temp<40)
            {
                Console.WriteLine("Zaczyna być słabo");
            }
            else
            {
                Console.WriteLine("A weź wyprowadzam się  na Alaskę");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Zadanie 10.");
            Console.WriteLine();

            Console.WriteLine("Podaj długosć boku A");
            string bok1 = Console.ReadLine();
            int bokA = 0;
            Int32.TryParse(bok1, out bokA);
            Console.WriteLine("Podaj długosć boku B");
            string bok2 = Console.ReadLine();
            int bokB = 0;
            Int32.TryParse(bok2, out bokB);
            Console.WriteLine("Podaj długosć boku C");
            string bok3 = Console.ReadLine();
            int bokC = 0;
            Int32.TryParse(bok3, out bokC);

            if(bokA+bokB>bokC||bokA+bokC>bokB||bokC+bokB>bokA)
            {
                Console.WriteLine("Z tych długości można stworzyć trójkąt.");
            }
            else
            {
                Console.WriteLine("Z boków o takich długościach nie można stworzyć trójkąta.");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Zadanie 11.");
            Console.WriteLine();
            Console.WriteLine("Podaj ocenę od 1 do 6: ");
            string ocena = Console.ReadLine();
            int ocenaA = 0;
            Int32.TryParse (ocena, out ocenaA);

            if(ocenaA==1)
            {
                Console.WriteLine("Niedostateczny");
            }
            else if(ocenaA==2) 
            {
                Console.WriteLine("Dopuszczający");
            }
            else if( ocenaA==3) 
            {
                Console.WriteLine("Dostateczny");
            }
            else if(ocenaA==4)
            {
                Console.WriteLine("Dobry");
            }
            else if(ocenaA==5) 
            {
                Console.WriteLine("Bardzo dobry");
            }
            else if(ocenaA==6)
            {
                Console.WriteLine("Celujący");
            }
            else 
            {
                Console.WriteLine("Podaj ocenę od 1 do 6");
            }

            Console.WriteLine();    
            Console.WriteLine();    
            Console.WriteLine("Zadanie 12.");    
            Console.WriteLine("Podaj numer dnia tygodnia od 1 do 7");
            string dzienTygodnia= Console.ReadLine();
            int dzien = 0;
            Int32.TryParse(dzienTygodnia, out dzien);
            switch(dzien)
            {
                case 1:
                    Console.WriteLine("Poniedziałek");
                    break;
                case 2:
                    Console.WriteLine("Wtorek");
                    break;
                case 3:
                    Console.WriteLine("Środa");
                    break;
                case 4:
                    Console.WriteLine("Czwartek");
                    break;
                case 5:
                    Console.WriteLine("Piątek");
                    break;
                case 6:
                    Console.WriteLine("Sobota");
                    break;
                case 7:
                    Console.WriteLine("Niedziela");
                    break;

            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Zadanie 13.");
            Console.WriteLine();

            Console.WriteLine("Podaj pierwszą liczbę: ");
            string pierwszaLiczba= Console.ReadLine();
            int pierwszaL = 0;
            Int32.TryParse(pierwszaLiczba, out pierwszaL);

            Console.WriteLine("Podaj drugą liczbę: ");
            string drugaLiczba=Console.ReadLine();
            int drugaL = 0;
            Int32.TryParse(drugaLiczba , out drugaL);

            Console.WriteLine("Podaj numer operacji do wykonania:\n1. Dodawanie \n2. Odejmowanie \n3.Mnożenie \n4.Dzielenie");
            string opcja = Console.ReadLine();
            int opcjaA = 0;
            Int32.TryParse(opcja, out opcjaA);

            if(opcjaA ==1)
            {
                Console.WriteLine("Twój wynik to: "+pierwszaL+drugaL);
            }
            else if(opcjaA ==2) 
            {
                Console.WriteLine("Twój wynik to:" + (pierwszaL-drugaL));
            }
            else if(opcjaA ==3) 
            {
                Console.WriteLine("Twój wynik to: " + pierwszaL * drugaL);
            }
            else if(opcjaA==4)
            {
                Console.WriteLine("Twój wynik to: " + pierwszaL / drugaL);
            }













        }
    }
}
