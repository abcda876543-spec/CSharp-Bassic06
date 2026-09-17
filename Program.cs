using System.Diagnostics;
using System.Reflection;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace C__Basics06
{
    internal class Program
    {
        static bool TryGetPrice(string title, out double price)
        {
            if (title == "Clean Code")
            {
                price = 25.5;
                return true;
            }
            else
            {
                price = 0;
                return false;
            }
        }
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
            static void PrintBookTitle(string title)
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
            static void AddBonusPagesByRef(ref int pages)
            {
                pages = pages + 50;

            }
            AddBonusPagesByRef(ref pages);
            Console.WriteLine(pages); //the value changed ref is a keyword lets the method gets the original value not the copy
            #endregion


            #region Question 8
            {
                double[] prices = { 25.5, 40.0 };
                static void ReplaceArray(ref double[] prices)
                {
                    prices = new double[] { 10.0, 12.5, 15.0 };
                }
                ReplaceArray(ref prices);
                Console.WriteLine(prices.Length);
            }
        }

            #endregion


        #region Question 9
        string title = "Clean Code";
        double price;


        #endregion

        #region Question 10
        void PrintBookInfo(string title, int pages = 300)
        {
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Pages: " + pages);
        }
        PrintBookInfo();
        PrintBookInfo();
    

        #endregion
        
    }
}
