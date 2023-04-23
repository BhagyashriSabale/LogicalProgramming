using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming.VendingMachine
{
    internal class VM
    {
        public static void GetMinimumNumbOfNotes(int amount)
        { 
            int[] notes = { 1000, 500, 100, 50, 10, 5, 2, 1 };
            int[] numbofNotes = new int[notes.Length];
            int i = 0;
            while(amount>0)
            {
                if (amount >= notes[i])
                {
                    int remainder = amount % notes[i];
                    numbofNotes[i] = amount / notes[i];
                    amount = remainder;
                }
                i++;

            }
            for(int j=0;j<notes.Length;j++) 
            {
                if (numbofNotes[j]!=0)
                {
                    Console.WriteLine(notes[j]+" rs:" + numbofNotes[j]);
                }
            }
        }

    }
}
