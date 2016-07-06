using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask2
{
    class Image
    {




        public static int[,] moves_important_images(int[,] img, int pic_width, int pic_height, int pic_x, int pic_y)
        {
            if ((pic_x == 0) || (pic_y == 0))
                return img;

            for (int i = 0; i < pic_height; i++)
                for (int j = 0; j < pic_width; j++)
                    img[i, j] = img[i + pic_y, j + pic_x];

            return img;
        }


    }
}
