using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace לומדתמחשבון.utilities
{
 
    internal class Game_logic
    { Random rnd = new Random();

        int score;
        public int[] addition()
        {
            int[] array = new int[3];

            int n1 = rnd.Next(1,20);
            int n2 = rnd.Next(1,20);
            int correct_answer = n1 + n2;
            array[0] = n1;
            array[1] = n2;
            array[2] = correct_answer;
            return array;

           

        }

       
      
       
        public int[] substraction()
        {
            int[] array = new int[3];

            int n1 = rnd.Next(1, 20);
            int n2 = rnd.Next(1, 20);
            int correct_answer = n1 - n2;

            array[0] = n1;
            array[1] = n2;
            array[2] = correct_answer;
            return array;

        }


        public int[] multiplycation()
        {
            int[] array = new int[3];

            int n1 = rnd.Next(1, 30);
            int n2 = rnd.Next(1, 30);
            int correct_answer = n1 * n2;
            array[0] = n1;
            array[1] = n2;
            array[2] = correct_answer;
            return array;
        }


        public int[] division()
        {
            int[] array = new int[3];

            int correct_answer;
            int n1 = rnd.Next(1, 20);
            int n2 = rnd.Next(1, 20);
            while(n1 % n2 != 0)
            {
                 n1 = rnd.Next(1, 20);
                 n2 = rnd.Next(1, 20);
                    
            }
            correct_answer = n1 / n2;
            array[0] = n1;
            array[1] = n2;
            array[2] = correct_answer;
            return array;

        }





    }
}
