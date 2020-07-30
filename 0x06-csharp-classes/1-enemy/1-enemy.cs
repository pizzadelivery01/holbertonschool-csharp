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
        public int health {get; set;}

        /// <summary>
        /// Initializes a new instance of the <see cref="Zombie"/> class.
        /// </summary>
        public Zombie()
        {
            health = 0;
        }
    }
}
