Random random = new Random();
int hero = 10;
int monster = 10;
String winner = "";

do {
    int heroAttack = random.Next(1, 10);
    monster -= heroAttack;
    Console.WriteLine($"Monster was damaged and lost {heroAttack} health and now has {monster} health.");
    if (monster > 0){
        int monsterAttack = random.Next(1, 10);
        hero -= monsterAttack;
        Console.WriteLine($"Hero was damaged and lost {monsterAttack} health and now has {hero} health.");
    }
    
    if (hero < 0){
        winner = "Monster";
        break;
    } else if (monster < 0){
        winner = "Hero";
        break;
    }
} while (hero > 0 || monster > 0);
Console.WriteLine($"The winner is {winner}");
