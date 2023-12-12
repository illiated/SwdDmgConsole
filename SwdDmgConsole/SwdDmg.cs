using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwdDmgConsole
{
    class SwdDmg
    {
        private const int BASE_DAMAGE = 3;
        private const int FLAME_DAMAGE = 2;

        public SwdDmg(int initialRoll)
        {
            roll = initialRoll;
            CalculateDamage();
        }

        /// <summary>
        /// Contains calculated damage.
        /// </summary>
        public int Damage { get; private set; }

        private int roll;

        /// <summary>
        /// Sets the roll and also calculates the damage.
        /// </summary>
        public int Roll
        {
            get { return roll; }
            set
            {
                roll = value;
                CalculateDamage();
            }
        }

        private bool flaming;

        /// <summary>
        /// Sets the flamimg condition and updates the damage calculation.
        /// True if the sword id flaming.
        /// </summary>
        public bool Flaming
        {
            get { return flaming; }
            set
            {
                flaming = value;
                CalculateDamage();
            }
        }

        private bool magic;

        /// <summary>
        /// Sets the magic condition and updates the damage calculation.
        /// True of the sword is magic.
        /// </summary>
        public bool Magic
        {
            get { return magic; }
            set
            {
                magic = value;
                CalculateDamage();
            }
        }


        private void CalculateDamage()
        {
            decimal magicMultiplier = 1;
            if (Magic)
            {
                magicMultiplier = 1.75M;
            }
            Damage = (int)(Roll * magicMultiplier) + BASE_DAMAGE;
            if (Flaming)
            {
                Damage += FLAME_DAMAGE;
            }


        }

    }
}

