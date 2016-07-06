using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            int frame_width = 60;
            int frame_height = 80;

            int[,] myImg = new int[frame_height, frame_width];

            int k = 1;

            for (int i =0; i < frame_height; i++)
                for (int j = 0; j < frame_width; j++)
                {
                    if (((i >= 10) && (i <= 40)) && ((j >= 15) && (j <= 45)))
                        myImg[i, j] = k;
                    else
                        myImg[i, j] = 0;
                }

            for (int i = 0; i < frame_height; i++)
            {
                for (int j = 0; j < frame_width; j++)
                    Console.Write(myImg[i, j]);
                Console.WriteLine();
            }
            Console.WriteLine("\n");


            Image.moves_important_images(myImg, 31, 31, 15, 10);

            for (int i = 0; i < frame_height; i++)
            {
                for (int j = 0; j < frame_width; j++)
                    Console.Write(myImg[i, j]);
                Console.WriteLine();
            }
        }
    }
}
