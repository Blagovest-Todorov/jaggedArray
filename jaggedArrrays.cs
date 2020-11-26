using System;

namespace _05.JaggedArrays
{
    class jaggedArrrays  // array of arrays--to take less Ram memory, to save moemory, litte used in practice
    {
        static void Main(string[] args)  //jaged arrayy -array on which riow the colums are different on different rows
        {
            // int[][] jagged = new int[3][]; // jaggerd array / we say how many rows, but we left the colums empty-no numbers size
            // jagged[0] = new int[3];   //on row tih index 0 we make here 3 colums
            //jagged[1] = new int[2];  //on row with index 1  we make 2 colums
            //jagged[2] = new int[5]; // on row with index 2  we make 5 colums !!

            int[][] jagged = new int[5][];
            for (int i = 1; i < jagged.Length; i++)
            {
                jagged[i] = new int[i];
            }
        }
    }
}
