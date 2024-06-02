using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// C# program to implement the Bubble Sort algorithm using System; 

namespace BubbleSort //box containing it all
{
    class Sort //class can be called anything
    {
        static int[] SortArray(int[] arr) //static makes it usable everywhere and global. what does a private static do? just make it private.
            //an array of intergers is made called sort array. not sure what the stuff in brackets is. is it a object?  
        {
            int temp = 0;  // temporary storage for moving the smaller array value.

            for (int outer = 0; (outer < arr.Length - 1); outer++) //for loop. outer = 0 is the counter, starts at 0. when counter is less than the length of 4 intergers it'll keep looping until its equal to 4. outer++ increses the counter each time. its 4 as 5 intergers -1 = 4. 
            {
                for (int inner = 0; inner < arr.Length - 1 - outer; inner++)//same as previous. however the -1 stops it from crashing as it stops int 4 being compared to nothing.but it minuses outer as each loop it does it will leave the already sorted numbers, increasing speed/efficiency.
                {
                    if (arr[inner] > arr[inner + 1]) //think of inner as position 0 and +1 as 1. If pos 0 is bigger than 1
                    {
                        temp = arr[inner + 1]; // it will make temp position 1's value.
                        arr[inner + 1] = arr[inner]; // then it will say that position 1's value is position 0
                        arr[inner] = temp; // then finally, position 0 is  the value of temp which was what 1 was.
                    } for (int counter = 0; counter < arr.Length; counter++) // another loop where it will keep looping the changes made. until the length is met

                        Console.Write(arr[counter] + " "); //here the values in the array "arr" is written. it has multiple intergers as its an array of intergers. the " " makes a space between each number
                    Console.WriteLine(); //simply makes a new line
                }
            }
            return arr; //the final result at the end
        }

        static void Main(string[] args) //entry point where it runs
        {
            int[] arr = { 799, 10, 49, 770, 648, 769, 239, 8 };//array being sorted
            arr = SortArray(arr);//passing - SortArray(arr) - this is data we want the function to run on. 
            Console.WriteLine("^ Final State ^");
            Console.ReadLine();


            //notes for word machine:

            //int number = 7;
            //string sentence = "This is a short sentence";
            //string[] s = sentence.Split(' ');
            //Console.WriteLine(s.Length);
            //for (int i=0; i< s.Length; i++)
            //{
            //    Console.WriteLine("Word number " + i + " is " + s[i]);
            //}
            //Console.ReadLine();
        }
    }
}