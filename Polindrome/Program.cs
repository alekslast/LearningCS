class Program
{
    static void Main(string[] args)
    {
        int variable        = 12_277_221;


        // // My solution
        // bool PolindromeChecker(int x)
        // {
        //     string convertedX   = Convert.ToString(x);
        //     int xLength         = convertedX.Length;
        //     int middle          = xLength / 2;
        //     int count           = 0;

        //     for (int i = 0; i <= middle; i++)
        //     {
        //         if (convertedX[i] == convertedX[^(i + 1)])
        //         {
        //             count++;
        //         }
        //         else
        //         {
        //             continue;
        //         }
        //     }

        //     if (count == (xLength / 2) + 1)
        //     {
        //         return true;
        //     }
        //     else
        //     {
        //         return false;
        //     }
        // }


        // Better solution
        bool PolindromeChecker(int x)
        {
            var y = x.ToString().ToCharArray();  
            Array.Reverse(y);
            return x.ToString() == new string(y);
        }


        Console.WriteLine(PolindromeChecker(variable));
    }
}
