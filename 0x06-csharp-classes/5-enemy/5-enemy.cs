using System;

namespace Enemies
{
    /// <summary> Represents and define a zombie empty class. </summary>
    public class Zombie 
    {
        /// <summary> Represents the healt of the zombie. </summary>
        private int health;

        /// <summary> Initializes health in 0. </summary>
        public Zombie()
        {
            health= 0;
        }

        /// <summary> If value is less than 0 </summary>
        public Zombie(int value)
        {
            if (value < 0)
            {
                throw new ArgumentException ("Health must be greater than or equal to 0");
            }
            else
            {
                health = value;
            }
        }

        /// <summary> Represents the name of the zombie </summary>
        private string name = ("(No name)");

        /// <summary> Retrieve and set the name value </summary>
        public string Name
        {
            get { return name;}
            set { name = value;}
        }

        /// <summary> Returns the health of the zombie </summary>
        public int GetHealth()
        {
            return health;
        }

        /// <summary> Prints zombie object attributes </summary>
        public override string ToString()
        {
            return String.Format ($"Zombie Name: {name} / Total Health: {health}");
        }
    }
}