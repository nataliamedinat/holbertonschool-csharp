using System;

namespace Enemies
{
    /// <summary> Represents and define a zombie empty class. </summary>
    public class Zombie 
    {
        /// <summary> Represents the healt of the zombie. </summary>
        public int health;

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
    }
}