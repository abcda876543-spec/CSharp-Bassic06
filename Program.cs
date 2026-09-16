namespace C__Basics06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Qestion 1
            {
                double[] prices = { 25.5, 33.75 };
                Console.WriteLine(prices[1]);
            }
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

            #region Question 4 
            static void PrintBookTitle (string title)
            {
                Console.WriteLine("Book title: " + title);
            }
            PrintBookTitle("Clean Code");
            #endregion


            #region Question 5
            int pages = 400;
            static void AddBonusPages(int pages)
            {
                pages = pages + 50;   //450 
            }
            AddBonusPages(pages);
            Console.WriteLine(pages);
            //400 the value didn't change cause int is avalue type and the methods gets a copy


            #endregion

            #region Question 6 
            {
                double[] prices = { 25.5, 40.0 };
                static void ApplyDiscount(double[] prices)
                {
                    prices[0] = prices[0] - 5;    //20.5
                }
               
                ApplyDiscount(prices);
                Console.WriteLine(prices[0]); 
                //20.5 value changed because double[] is a ref type and the method gets the original value
            }
            #endregion


            #region Question 7
            static void AddBonusPagesByRef(ref int pages){
                pages = pages + 50;

            }
            AddBonusPagesByRef(ref pages);
            Console.WriteLine(pages); //the value changed ref is a keyword lets the method gets the original value not the copy
            #endregion
        }
    }
}
