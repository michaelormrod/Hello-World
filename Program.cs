using System;

namespace Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CalculatePascalLayerTotal(12));
        }

        public static int CalculatePascalLayerTotal(int layer)
        {

            // Your code goes here
            int result = 0; // variable to store result

            int[,] pascalarray = new int[layer, layer]; //array to store values in triangle

            //Iterate through each line in the layer
            for (int line = 0; line < layer; line++)
            {
                //Iterate through each value in the line, each line has number of entries as line number
                for (int entries = 0; entries < line; entries++)
                {
                    // First and last values in every row are 1 
                    if (line == entries || entries == 0)
                    {
                        pascalarray[line, entries] = 1;


                    }
                    else
                    { //Other values sum of the value above and the value to the left above

                        pascalarray[line, entries] = pascalarray[line - 1, entries - 1]
                                                + pascalarray[line - 1, entries];
                        Console.WriteLine(pascalarray[line, entries]);
                    }

                }





            }

            //Now we have all values, need to return sum of the values in the last layer
            //loop round last layer
            for (int items = 0; items < layer; items++)
            {
                result += pascalarray[layer - 1, items];
            }

            return result;

        }
    }
}
