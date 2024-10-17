using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberTextAdventure
{
    // This class holds the data applicable for the player object.

    internal class Player
    {
        private string _name { get; }
        private int _maxHealth { get; }
        private int _currHealth { get; }
        private int _attack { get; }
        private int _defense { get; }
        private bool _isDead { get; }

        public Player()
        {
            _name = "Dave";
            _maxHealth = 1;
            _currHealth = _maxHealth;
            _attack = 1;
            _isDead = false;
        }

        public Player(string newName)
        {
            _name = newName;
            _maxHealth = 100;
            _currHealth = _maxHealth;
            _attack = 10; // Basic unarmed attack
            _isDead = false;
        }

        public void Attack()
        { }

        public void TakeDamage()
        { }

        public void CheckDeath()
        {
            
        }
    }
}
