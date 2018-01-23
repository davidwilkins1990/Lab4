using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace preworkAssessment
{
    class Program
    {

        public class PeopleMoverTrack
        {
            double total = 4.2;
            int quantity = 2;

            public double getTotal()
            {
                return total;
            }

            public int getQuantity()
            {
                return quantity;
            }


        }


        static void Main(string[] args)
        {

            PeopleMoverTrack pmt = new PeopleMoverTrack();

            double price = pmt.getTotal() / (Convert.ToDouble(pmt.getQuantity()));

            Console.WriteLine(price);

            int x = 12;
            var y = "whatever you want";
            

            Console.WriteLine(y);
            Console.WriteLine(x);


            //doubles are bigger and more precise than float and less of a pain to use;




            Console.Read();



        }
    }
}
