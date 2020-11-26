using System;

namespace _05.JaggedArrays
{
    class jaggedArrrays  // array of arrays--to take less Ram memory, to save moemory, litte used in practice
    {
        static void Main(string[] args)  //jaged arrayy -array on which riow the colums are different on different rows
        {
           // int[][] jagged = new int[3][]; // jaggerd array / we say how many rows, but we left the colums empty-no numbers size
           // jagged[0] = new int[3];
            //jagged[1] = new int[2];
            //jagged[3] = new int[5];it

            int[][] jagged = new int[5][];
            for (int i = 1; i < jagged.Length; i++)
            {
                jagged[i] = new int[i];
            }
        }
    }
}
