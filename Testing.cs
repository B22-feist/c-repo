using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Runtime.CompilerServices;

class Primecheck
{
    List<int> sort(List<int> userArray)
    {
        int userArrayLength = userArray.Count;
        for (int i = 1; i <= userArrayLength-1; i++)
        {
            for (int x = 0; x <= userArrayLength-i-1; x++)
            {
                int holding;
                if (userArray[x] > userArray[x + 1])
                    {
                        holding= userArray[x+1];
                        userArray[x+1] = userArray[x];
                        userArray[x] = holding;
                    }
            }
        }

        return userArray;
    }
    static void Main()
    {
        Primecheck bubble = new Primecheck();
        List<int> userList = new List<int>();

        Console.WriteLine("How many times do you want to enter a value into this set");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
        string repeatTimes = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.

#pragma warning disable CS8604 // Possible null reference argument.
        int item = int.Parse(repeatTimes);
#pragma warning restore CS8604 // Possible null reference argument.

        for (int a = 1; item >= a; a++)
        {
            Console.WriteLine("Enter your next item for the array");

#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            string StringParsedInt = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.

#pragma warning disable CS8604 // Possible null reference argument.
            int nextItem = int.Parse(StringParsedInt);
#pragma warning restore CS8604 // Possible null reference argument.

            userList.Add(nextItem);
        }       
    List<int> outputArray = bubble.sort(userList);
    
    for (int varx =0; varx <= outputArray.Count; varx++)
        {
            Console.WriteLine(outputArray[varx]);
        }
    }
}
