// game loop
while (true) {
    var inputs = readline().split(' ');
    var spaceX = parseInt(inputs[0]);
    var spaceY = parseInt(inputs[1]);
    
    var highest = 0;
    var target = 0;
    
    
    for (var i = 0; i < 8; i++)
    {
        var mountainH = parseInt(readline()); // represents the height of one mountain, from 9 to 0. Mountain heights are provided from left to right.
        
        // Update mountain highest with current mountain height
        if (mountainH > highest)
        {
            highest = mountainH;
            target = i;
        }
    }
    
    // If mountain height is not zero the arracy and space x are equal and space x is i fire
    if (highest > 0 && spaceX == target)
    {
        print('FIRE');
    }
    else
    {
        print('HOLD');
    }
}
