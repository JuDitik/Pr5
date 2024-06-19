using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr_5.Spells
{
    internal class EarthSpikes : ISpell
    {
        public int Damage { get; } = 15;
        public int ManaCost { get; } = 5;

        public void CastSpell(IDamageble target, Mage caster)
        {
            target.TakeDamage(Damage);
        }
    }
}