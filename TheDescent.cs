using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

class Player
{
    static void Main(string[] args)
    {

        // game loop
        while (true)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int spaceX = int.Parse(inputs[0]);
            int spaceY = int.Parse(inputs[1]);
            
            // Store the position of the highest mountain
            int highest = 0;
            // Store the position of the target for the ship to fire on
            int target = 0;
            
            for (int i = 0; i < 8; i++)
            {
                int mountainH = int.Parse(Console.ReadLine()); // represents the height of one mountain, from 9 to 0. Mountain heights are provided from left to right.
                
                // Update highest and target location based on mountain height
                if (mountainH > highest)
                {
                    highest = mountainH;
                    target = i;
                }
            }
            
            // If highest is greater than zero and ship x position is above the target
            if ((highest > 0) && (spaceX == target))
            {
                Console.WriteLine("FIRE");
            }
            // Else hold fire
            else
            {
                Console.WriteLine("HOLD");
            }
        }
    }
}
