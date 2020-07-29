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