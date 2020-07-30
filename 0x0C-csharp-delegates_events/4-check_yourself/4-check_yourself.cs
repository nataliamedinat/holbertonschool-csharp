using System;

///<summary> public enum </summary>
public enum Modifier
{
    ///<summary> Weak </summary>
    Weak,

    ///<summary>Base</summary>
    Base,

    ///<summary> strong</summary>
    Strong
}

///<summary>CurrentHPargs class</summary>
public class CurrentHPArgs : EventArgs
{
    ///<summary>Not modifable current hp float</summary>
    public readonly float currentHp;

    ///<summary>CurrentHPargs constructor</summary>
    public CurrentHPArgs(float newHp)
    {
        this.currentHp = newHp;
    }
}

delegate void CalculateHealth(float health);

///<summary> delegate calculate modifier </summary>
public delegate float CalculateModifier(float baseValue, Modifier modifier);

///<summary> Class player </summary>
class Player
{
    private string name;
    private float maxHp;
    private float hp;
    public EventHandler<CurrentHPArgs> HPCheck;
    private string status;

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
        this.status = $"<name> is ready to go!";
        this.HPCheck = this.CheckStatus;
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
        {
            Console.WriteLine($"{name} takes 0 damage!");
            damage = 0f;
        }
        else
            Console.WriteLine($"{name} takes {damage} damage!");
        float newHp = this.hp - damage;
        ValidateHP(newHp);
    }

   ///<summary> Heal damage </summary>
    public void HealDamage(float heal)
    {
        if (heal < 0)
        {
            Console.WriteLine($"{name} heals 0 HP!");
            heal = 0f;
        }
        else
            Console.WriteLine($"{name} heals {heal} HP!");
        
        float newHp = this.hp + heal;
        ValidateHP(newHp);
    }

    ///<summary> Validate hp </summary>
    public void ValidateHP(float newHp)
    {
        if (newHp < 0)
            this.hp = 0;
        else if (newHp > this.maxHp)
            this.hp = this.maxHp;
        else
            this.hp = newHp;
        this.HPCheck(this, new CurrentHPArgs(this.hp));
    }

    ///<summary> Method</summary>
    public float ApplyModifier(float baseValue, Modifier modifier)
    {
        if(modifier == Modifier.Weak)
            return baseValue / 2;
        else if(modifier == Modifier.Base)
            return baseValue;
        else
            return baseValue * 1.5f;
        
    }

    ///<summary> Method</summary>
    private void CheckStatus(object sender, CurrentHPArgs e)
    {
        if (e.currentHp == this.maxHp)
            this.status = $"{this.name} is in perfect health!";
        else if (e.currentHp >= (this.maxHp / 2))
            this.status = $"{this.name} is doing well!";
        else if (e.currentHp >= (this.maxHp / 4))
            this.status = $"{this.name} isn't doing too great...";
        else if (e.currentHp > 0)
            this.status = $"{this.name} needs help!";
        else
            this.status = $"{this.name} is knocked out!";
        Console.WriteLine(this.status);
    }
}