using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_List_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayStorage<string> listOne = new ArrayStorage<string>();
            listOne.AddItem("Hello ");
            listOne.AddItem("second ");
            listOne.AddItem("test!");

            foreach (string item in listOne) { Console.WriteLine(item); }
            Console.ReadLine();

            //listOne.RemoveItem();
            //listOne.ToString();

            //foreach (string item in listOne) { Console.WriteLine(item); }
            //Console.ReadLine();

            ArrayStorage<string> listTwo = new ArrayStorage<string>();
            listTwo.AddItem("Hey ");
            listTwo.AddItem("first ");
            listTwo.AddItem("test!");

            foreach (string item in listTwo) { Console.WriteLine(item); }
            Console.ReadLine();

            //listTwo.RemoveItem();
            //listTwo.ToString();

            //foreach (string item in listTwo) { Console.WriteLine(item); }
            //Console.ReadLine();

            ArrayStorage<string> zipList = new ArrayStorage<string>();
            zipList = zipList.ZipList(listOne, listTwo);

            foreach (string item in zipList) { Console.WriteLine(item); }
            Console.ReadLine();

            //ArrayStorage<string> SubtractList = listOne - listTwo;
            //foreach (string item in listOne){ Console.WriteLine(item); }
            //Console.ReadLine();
        }
    }
}
