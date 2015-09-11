#include <iostream>
#include <string>
#include <vector>
#include <algorithm>

using namespace std;

int main()
{

    // game loop
    while (1) {
        int spaceX;
        int spaceY;
        
        // highest and target to hold the height and position of the highest mountain
        int highest = 0;
        int target = 0;
        
        cin >> spaceX >> spaceY;
        cin.ignore();
        
        // Iterate through the mountain range
        for (int i = 0; i < 8; i++)
        {
            int mountainH = 0; // represents the height of one mountain, from 9 to 0. Mountain heights are provided from left to right.
            cin >> mountainH;
            cin.ignore();
            
            // If the current mountain has a height greater than highest update highest and position of mountain
            if (mountainH > highest)
            {
                highest = mountainH;
                target = i;
            }
        }
        
        // If a mountain is present and the ship is above it fire
        if ((highest > 0) && (spaceX == target))
        {
            cout << "FIRE" << endl;
        }
        
        // If no highest mountain is present or the ship is not above it hold
        else
        {
            cout << "HOLD" << endl;
        }
    }
}
