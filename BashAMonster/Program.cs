using BashAMonster;
Random generator = new();

Skeleton SkellyJonas = new Skeleton("Jonas");
Zombie ZombPeter = new Zombie("Peter");

Enemy[] enemyArr = { SkellyJonas, ZombPeter };
int currentEnemy = generator.Next(2);
string answer;

while (true)
{
    while (enemyArr[currentEnemy].HP > 0)
    {
        System.Console.Clear();
        enemyArr[currentEnemy].Draw();
    }
    System.Console.Clear();
    System.Console.WriteLine("Do you want to play again? y/n");
    answer = System.Console.ReadLine();
    while (answer != "y" && answer != "n")
    {
        System.Console.WriteLine("You have to write y or n");
        System.Console.WriteLine("Do you want to play again? y/n");
        answer = System.Console.ReadLine();
    }
    if (answer == "y")
    {
        enemyArr[currentEnemy].HP = 100;
        currentEnemy = generator.Next(2);
    }
    else
    {
        break;
    }
}