using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulletGame
{
    public class GameLogic
    {
        // represent bullet position
        private int bulletPosition;

        public GameLogic()
        {
            
        }

        /// <summary>
        /// Load the Bullet position at beginning
        /// </summary>
        public void LoadBullet()
        {
            this.bulletPosition = 1;
        }

        /// <summary>
        /// Shuffle the Bullet Position in Random Manner
        /// </summary>
        public void SpinChambers()
        {
            this.bulletPosition = new Random().Next(123232) % 6 + 1;            
        }

        /// <summary>
        /// Fire The Bullet by comparing with bullet position and current position
        /// </summary>
        /// <param name="position">Current Bullet Number</param>
        /// <returns>Status of Firing Bullet</returns>
        public bool FireTheBullet(int position)
        {
            return this.bulletPosition == position;
        }
    }
}
