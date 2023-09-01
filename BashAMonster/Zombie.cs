namespace BashAMonster;

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