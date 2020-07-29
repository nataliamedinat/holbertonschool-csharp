using System;

///<summary> Class player </summary>
class Player
{
    private string name;
    private float maxHp;
    private float hp;

    ///<summary> Constructor </summary>
    public Player(string name = "Player", float maxHp = 100f)
    {

        if (maxHp < 0)
        {
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
            this.maxHp = 100f;
        }
        else
        {
            this.maxHp = maxHp;
        }
        this.name = name;
        this.hp = this.maxHp;
    }

    ///<summary> Method that prints health </summary>
    public void PrintHealth()
    {
        Console.WriteLine($"{name} has {hp} / {maxHp} health");
    }

    ///<summary> Calculates damage</summary>
    public void TakeDamage(float damage)
    {
        if (damage < 0)
            Console.WriteLine($"{name} takes 0 damage!");
        else
            Console.WriteLine($"{name} takes {damage} damage!");
        this.ValidateHP(this.hp - damage);
    }

    ///<summary> Heal damage </summary>
    public void HealDamage(float heal)
    {
        if (heal < 0)
            Console.WriteLine($"{name} heals 0 HP!");
        else
            Console.WriteLine($"{name} heals {heal} HP!");
        this.ValidateHP(this.hp + heal);
    }

    public void ValidateHP(float newHp)
    {
        if (newHp < 0)
            this.hp = 0;
        else if (newHp > this.maxHp)
            this.hp = this.maxHp;
        else
            this.hp = newHp;
    }
}