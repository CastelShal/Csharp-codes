namespace AllPracs
{
    internal class Linkq
    {
        static void getMatrix(int[,] mat)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Enter Element [{i}][{j}]: ");
                    mat[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }

        static void display(int[,] mat)
        {
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine($"{mat[i,0]}, {mat[i,1]}, {mat[i,2]}");
            }
        }
        
        public static void Main(string[] args)
        {
            Console.WriteLine("Matrix 1:");
            int[,] mat1 = new int[3, 3];
            getMatrix(mat1);
            display(mat1);
            Console.WriteLine("Matrix 2:");
            int[,] mat2 = new int[3, 3];
            getMatrix(mat2);
            display(mat2);

            int[,] result = new int[3, 3];
            
            // Matrix multiply
            for(int i = 0;i < 3; i++)
            {
                for(int j=0; j < 3; j++)
                {
                    result[i, j] = 0;
                    for (int k = 0; k < 3; k++)
                    {
                        result[i, j] += mat1[i, k] * mat2[k, j];
                    }
                }
            }
            Console.WriteLine("Result is: ");
            display(result);

        }
    }
}
