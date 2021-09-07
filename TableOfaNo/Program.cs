using System;

namespace TableOfaNo
{
    class Program
    {
        static void Main(string[] args)
        {
            FindTable obj = new FindTable();
            obj.Table();
        }
    }
    class FindTable
    {
        public void Table()
        {
            Console.WriteLine("Enter the number to print the Table :");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                //Printing table of number entered by user            
                Console.Write("{0} X {1} = {2} \n", num, i, num * i);
            }
            Console.ReadLine();
        }
    }
}
