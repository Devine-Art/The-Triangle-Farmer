using System.Formats.Asn1;
using System.Security.Cryptography.X509Certificates;

namespace Triangle Farmer
{
    public class Program
    {
        static void Main(string[] args)
        {
            //ask user for variables and assign them
            Console.WriteLine("Enter base of triangle:");
            int basenumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter height of triangle:");
            int heightnumber = int.Parse(Console.ReadLine());


            //Calculate area
            double areasize = (basenumber * heightnumber) *.5

            //write area to console
	    Console.WriteLine("area of triangle");
            Console.WriteLine(areasize);

        }
    }
}
