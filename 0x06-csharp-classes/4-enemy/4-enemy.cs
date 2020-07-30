using System;

namespace Enemies
{
    /// <summary>
    ///  Represents an enemy zombie class
    /// </summary>
    public class Zombie
    {
        /// <summary>
        /// Gets or sets health of zombie.
        /// </summary>
        private int health;
        private string name = "(No name)";

        /// <summary>
        /// Initializes a new instance of the Zombie class.
        /// </summary>
        public Zombie()
        {
            health = 0;
        }
        /// <summary>
        /// Initializes a new instance of the Zombie class
        /// </summary>
        /// <param name="value">zombies health</param>
        public Zombie(int value)
        {
             if (value < 0)
                throw new ArgumentException("Health must be greater than or equal to 0");
            else
                health = value;
        }
        /// <summary>
        /// Gets health of Zombie
        /// </summary>
        /// <returns>health of zombie</returns>
        public int GetHealth()
        {
            return health;
        }
        /// <summary>
        /// Gets or Sets zombie name
        /// </summary>
        /// <value>name of zombie for setter</value>
        public string Name {get => name; set => value;}
    }
}
