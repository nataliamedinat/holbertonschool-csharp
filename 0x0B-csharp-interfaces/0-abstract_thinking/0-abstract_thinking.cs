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