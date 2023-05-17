using System;

namespace PROJECTSTATISTICS_DR_SAMER
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the number of items to known statistics attribute : ");



           
            int n = int.Parse(Console.ReadLine());

            int[] items = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter item"+( i + 1)+"=");
                items[i] = int.Parse(Console.ReadLine());
            }




          
            Array.Sort(items);  
            Console.WriteLine("---------------");
           



            double median; 
            if (n % 2 == 0)
            {
                int mid_INDEXER1 = n / 2;
                int mid_INDEXER2 = mid_INDEXER1 - 1;
                median = (items[mid_INDEXER1] + items[mid_INDEXER2]) / 2.0;
            }
            else
            {
                int mid_INDEXER = n / 2;
                median = items[mid_INDEXER];
            }

            Console.WriteLine("median =" + median);
            Console.WriteLine("---------------");
           




            int mode = 0; 
            int maxCount = 0;
            for (int i = 0; i < n; i++)
            {
                int count = 0;
                for (int C = i + 1; C < n; C++)
                {
                    if (items[i] == items[C])
                    {
                        count++;
                    }
                }

                if (count > maxCount)
                {
                    mode = items[i];
                    maxCount = count;
                }
            }
            
            Console.WriteLine("MODE =" +mode);
            Console.WriteLine("---------------");
        




            int range = items[n - 1] - items[0];  
            Console.WriteLine("range =" +range);

            Console.WriteLine("---------------");






           
            int Q1; 
            if (n % 4 == 0)
            {
                int _INDEXER= n / 4;
                Q1 = items[_INDEXER - 1];
            }
            else
            {
                int _INDEXER = n / 4;
                Q1 = items[_INDEXER];
            }
            Console.WriteLine("Q1 =" + Q1);


            Console.WriteLine("---------------");






          
            int Q3; 
            if (n % 4 == 0)
            {
                int _INDEXER = (3 * n) / 4;
                Q3 = items[_INDEXER - 1];
            }
            else
            {
                int _INDEXER = (3 * n) / 4;
                Q3 = items[_INDEXER];
            }

          Console.WriteLine("Q3 =" + Q3);

            Console.WriteLine("---------------");
        
            int p90_INDEXER = (int)(0.9 * n);  
            int p90= items[p90_INDEXER];
            Console.WriteLine("P90 =" + p90);
            Console.WriteLine("---------------");




           
            int iQr = Q3 - Q1;
            Console.WriteLine("Interquartile Range = " +iQr);
            Console.WriteLine("---------------");




          
            double minoutlier = (Q1 - 1.5 * iQr);


            double maxoutlier = (Q3 + 1.5 * iQr);
            Console.WriteLine("Outlier Region Boundaries  FROM "+ minoutlier + " TO "+ maxoutlier);
            Console.WriteLine("---------------");




           
            Console.Write("Enter a value to check if it's an outlier or not ");
          
            int value = int.Parse(Console.ReadLine());
            if (value < minoutlier|| value > maxoutlier)
            {
                Console.WriteLine(value+"outlier");
            }
            else
            {
                Console.WriteLine(value + " not outlier");

            }
        }
    }
}
           





          