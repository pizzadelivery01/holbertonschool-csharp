using System;

namespace Enemies
{
    /// <summary>
    ///  Represents an enemy zombie class
    /// </summary>
    public class Zombie
    {
        /// <summary>
        /// health of zombie.
        /// </summary>
        public int health {get; set;}

        /// <summary>
        /// Initializes a new instance of the <see cref="Zombie"/> class.
        /// </summary>
        public Zombie()
        {
            health = 0;
        }
        /// <summary>
        /// Sets health of zombie to value
        /// </summary>
        /// <param name="value"></param>
        public Zombie(int value)
        {
            if(value < 0)
            {
                throw new ArgumentException("Health must be greater than or equal to 0");
            }
            else
            {
                health = value;
            }
        }
    }
}
