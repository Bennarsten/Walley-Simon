using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace ConsoleApp1 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int calcfee;
            
            Console.WriteLine("Hello World test!");
            Car testCar = new Car();
            DateTime[] MyTime = new DateTime[5];
            

            MyTime[0] = new DateTime(2013, 2, 4, 15, 15, 30); // 13
            MyTime[1] = new DateTime(2013, 2, 4, 15, 25, 30); // 13
            MyTime[2] = new DateTime(2013, 2, 4, 15, 35, 30); // 18
            MyTime[3] = new DateTime(2013, 2, 4, 16, 35, 30); // 18
            MyTime[4] = new DateTime(2013, 2, 4, 17, 25, 30); // 13
            
            //MyTime[5] = new DateTime(2013, 2, 7, 17, 15, 30);
            //MyTime[6] = new DateTime(2013, 2, 8, 18, 15, 30);
            //MyTime[7] = new DateTime(2013, 2, 9, 18, 15, 30);
            /*MyTime[6] = new DateTime();
            MyTime[6] = DateTime.Now;
            MyTime[7] = new DateTime();
            MyTime[7] = DateTime.Now;
            MyTime[7].AddMinutes(5);
            */

            String teststring;
            teststring = testCar.GetVehicleType();
            TollCalculator myFee = new TollCalculator();
            calcfee = myFee.GetTotalTollFee(testCar, MyTime);
            Console.WriteLine("");
            Console.WriteLine("MyTime[1] " + MyTime[1] );
            Console.WriteLine("my toll fee: " + calcfee);
        }        
    }
}
