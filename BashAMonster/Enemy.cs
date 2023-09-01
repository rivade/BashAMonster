namespace BashAMonster;

public class Enemy
{
    public int HP;
    public string Name;
    public int Damage;
    public virtual void Attack() { }
    public virtual void Draw() { }
}