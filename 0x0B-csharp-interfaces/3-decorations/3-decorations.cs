using System;

    ///<summary>Base class </summary>
    public abstract class Base
    {
        ///<summary>Public property </summary>
        public string name;

        ///<summary>Override tostring method</summary>
        public override string ToString()
        {
              return String.Format ($"{name} is a {this.GetType()}");
        }      
    }

    ///<summary>Interface interactive  </summary>
    interface IInteractive
    {
        ///<summary> Method interact </summary>
        void Interact();
    }

    ///<summary> Interface breakable </summary>
    interface IBreakable
    {
        ///<summary> Property int durability</summary>
        int durability {get; set;}

        ///<summary> Break method </summary>
        void Break();
    }

    ///<summary> Collectable interface </summary>
    interface ICollectable
    {
        ///<summary> Bool property </summary>
        bool isCollected {get; set;}

        ///<summary> Collect method </summary>
        void Collect();
    }

    ///<summary>  Class door </summary>
    class Door : Base, IInteractive
    {
        public Door(string named = "Door")
        {
            name = named;
        }

        public void Interact()
        {
            Console.WriteLine($"You try to open the {name}. It's locked.");
        }
    }

    ///<summary> Class decoration </summary>
    class Decoration : Base, IInteractive, IBreakable
    {
        public bool isQuestItem;
        public int durability  {get; set;}

        public Decoration(string name = "Decoration", int durability = 1, bool isQuestItem = false)
        {
            if (durability <= 0)
                throw new Exception("Durability must be greater than 0");
            this.name = name;
            this.durability = durability;
            this.isQuestItem = isQuestItem;
        }

        public void Interact()
        {
            if (durability <= 0)
                Console.WriteLine($"The {name} has been broken.");
            else if (isQuestItem == true)
                Console.WriteLine($"You look at the {name}. There's a key inside.");
            else
                Console.WriteLine($"You look at the {name}. Not much to see here.");
        }

        public void Break()
        {
            durability -= 1;

            if(durability > 0)
                Console.WriteLine($"You hit the {name}. It cracks.");
            else if (durability == 0)
                Console.WriteLine($"You smash the {name}. What a mess.");
            else if (durability < 0)
                Console.WriteLine($"The {name} is already broken.");
        }
    }