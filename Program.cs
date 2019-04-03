using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monte_Carlo_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many random points?\n 1 = 10, 2 = 100, 3 = 1000, 4 = 10000");
            int userImput = Convert.ToInt32(Console.ReadLine());

            int repetitions = 0;
           
            if (userImput == 1)
                repetitions = 10;
            else if (userImput == 2)
                repetitions = 100;
            else if (userImput == 3)
                repetitions = 1000;
            else if (userImput == 4)
                repetitions = 10000;
           
            
            double[] xVar = new double[repetitions];
            double[] yVar = new double[repetitions];
            double[] xyDistance = new double[repetitions];
            List<double> xyOverlap = new List<double>();
            Random RandomNumber = new Random();

            for (int i = 0; i < repetitions; i++)
            {
                xVar[i] = RandomNumber.NextDouble();
                yVar[i] = RandomNumber.NextDouble();
                xyDistance[i] = Math.Sqrt((xVar[i] * xVar[i]) + (yVar[i] * yVar[i]));
                
            }

            Array.Sort(xyDistance);
            foreach (var i in xyDistance)
            {
                if (i <= 1)
                {
                    xyOverlap.Add(i);
                }
            }

            Console.WriteLine("The estimated area: " + 4 * (xyOverlap.Count / Convert.ToDouble(repetitions)));



        }

    }
}
        
    

