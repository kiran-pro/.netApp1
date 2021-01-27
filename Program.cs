using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalKirandeepKaur
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Methods my = new Methods();

            do
            {
                int input = Display();
                switch (input)
                {
                    case 1:
                        Console.WriteLine("\n CityID  CityName       IsCapital   CountryName      ContinentName         Population \n ");
                      my.GetCities();
                        break;
                    case 2:
                        Console.WriteLine("\n CountryID CountryName    ContinentName         Capital                 Language             Currency \n ");

                       my.GetCountries();
                        break;
                    case 3:
                        my.addCountry();
                        break;
                    case 4:
                       my. addCity();
                        break;
                    case 5:
                        my.updateCity();
                        break;
                    case 6:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid Option !!!!");
                        break;




                }
            } while (true);
        }

        static int Display()
        {
            Console.WriteLine("\n\n+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+\n");
            Console.WriteLine("\t1 - Get all Cities");
            Console.WriteLine("\t2 -  Get all Countries ");
            Console.WriteLine("\t3 -  Add new Country");
            Console.WriteLine("\t4 -  Add new City");
            Console.WriteLine("\t5 -  Update a City");
            Console.WriteLine("\t6 - Exit");

            Console.Write("\nEnter your choice: ");
            return int.Parse(Console.ReadLine());

        }



       
    }
}
