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

    ///<summary> Class that inherits from base and from all the interfaces </summary>
    class TestObject : Base, IInteractive, ICollectable, IBreakable
    {

        public int durability { get; set; }
        public bool isCollected { get; set; }

        public void Interact()
        {

        }

        public void Break()
        {

        }

        public void Collect()
        {

        }

    }