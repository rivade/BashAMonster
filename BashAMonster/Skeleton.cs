namespace BashAMonster;

public class Skeleton : Enemy
{
    Random generator = new();
    public Skeleton(string inputName)
    {
        HP = 100;
        Name = inputName;
    }

    public override void Attack()
    {
        Damage = generator.Next(10, 25);
        HP -= Damage;
        System.Console.WriteLine("(Sounds of bones cracking)");
        System.Console.WriteLine($"You did {Damage} damage!");
        if (HP <= 0)
        {
            System.Console.WriteLine("He dead xd");
        }
        else
        {
            System.Console.WriteLine($"He has {HP} health remaining");
        }
        System.Console.ReadKey();
    }

    public override void Draw()
    {
        System.Console.WriteLine(@"      .-.
     (o.o)
      |=|
     __|__
   //.=|=.\\
  // .=|=. \\
  \\ .=|=. //
   \\(_=_)//
    (:| |:)
     || ||
     () ()
     || ||
     || ||
    ==' '==");
        System.Console.WriteLine($"{Name}'s HP = {HP}");
        System.Console.WriteLine("Press any key to attack!");
        System.Console.WriteLine();
        Console.ReadKey();
        Attack();
    }
}