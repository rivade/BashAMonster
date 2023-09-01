namespace BashAMonster;

public class Enemy
{
    public int HP;
    public string Name;
    public int Damage;
    public virtual void Attack() { }
    public virtual void Draw() { }
}

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

public class Zombie : Enemy
{
    Random generator = new();
    public Zombie(string inputName)
    {
        HP = 100;
        Name = inputName;
    }
    public override void Attack()
    {
        Damage = generator.Next(5, 15);
        HP -= Damage;
        System.Console.WriteLine($"({Name} groans loudly)");
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
        System.Console.WriteLine(@"                                (()))
                               /|x x|
                              /\( - )
                      ___.-._/\/
                     /=`_'-'-'/  !!
                     |-{-_-_-}     !
                     (-{-_-_-}    !
                      \{_-_-_}   !
                       }-_-_-}
                       {-_|-_}
                       {-_|_-}
                       {_-|-_}
                       {_-|-_}
                   ____%%@ @%%_______");
        System.Console.WriteLine($"{Name}'s HP = {HP}");
        System.Console.WriteLine("Press any key to attack!");
        System.Console.WriteLine();
        Console.ReadKey();
        Attack();
    }
}
