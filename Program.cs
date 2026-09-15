namespace C__Basics06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Qestion 1
            double[] prices = { 25.5, 33.75 };
            Console.WriteLine(prices[1]);
            #endregion


            #region Question 2
            int[,] shelfCopies = new int[2, 2] {
                {3,5 },
                {1,4 }
            };
            Console.WriteLine(shelfCopies[1, 0]);
            #endregion

            #region Question 3
           static void PrintWelcomeMessage()
            {
                Console.WriteLine("Welcome to the Library!");
            }
            PrintWelcomeMessage();
            #endregion
        }
    }
}
