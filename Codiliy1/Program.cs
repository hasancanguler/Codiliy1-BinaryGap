using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codiliy1
{
    class Program
    {
        private static string result = "Anything";



        static async Task<string> GetSomething()
        {
            await Task.Delay(5);
            result = "Hello world!";
            return "Something";
                
        }

        static void Main(string[] args)
        {
            
            try
            {
                Console.WriteLine("Hello");
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("A");
            }
            catch (Exception)
            {
                Console.WriteLine("B");
            }
            finally
            {
                Console.WriteLine("C");
            }


            //int[] A = { 2 };
            ////int[] A = { 1,2,3 };
            //solution(A);
        }


        static int solution(int[] ItemList)
        {
            int Temp = 0;
            int MaxItem = 1;

            for (int index = 0; index < ItemList.Length; index++)
            {
                for (int index2 = 0; index2 < ItemList.Length; index2++)
                {
                    if ((ItemList[index] < ItemList[index2]))
                    {
                        Temp = ItemList[index];
                        ItemList[index] = ItemList[index2];
                        ItemList[index2] = Temp;
                    }
                }
            }

            int[] ItemList2 = ItemList.Where(x => x > 0).ToArray();

            //Negative
            if (ItemList2.Length == 0)
                return MaxItem;

            bool FoundFlag = false;
            for (int index = 0; index < ItemList2.Length - 1; index++)
            {
                if (ItemList2[index + 1] - ItemList2[index] > 1)
                {
                    FoundFlag = true;
                    MaxItem = ItemList2[index] + 1;
                    return MaxItem;
                }
            }

            if (!FoundFlag)
            {
                if (ItemList2.Length > 1)
                    MaxItem = ItemList2[ItemList2.Length - 1] + 1;
                else
                    MaxItem = 1;
                return MaxItem;
            }

            return 1;
        }


    }
}
