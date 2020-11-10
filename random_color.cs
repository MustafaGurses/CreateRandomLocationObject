using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random_Object.Object
{
    public static class random_color
    {
        public static ArrayList rgb_number()
        {
            ArrayList rgb_numbers = new ArrayList();
            while(rgb_numbers.Count < 4)
            {
                int rand = new Random().Next(0, 255);
                if (!rgb_numbers.Contains(rand))
                    rgb_numbers.Add(rand);
            }
            return rgb_numbers;
        }
    }
}
