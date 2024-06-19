using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr_5.Spells
{
    internal class EarthQuake : ISpell
    {
        public int Damage { get; } = 80;
        public int ManaCost { get; } = 30;

        public void CastSpell(IDamageble target, Mage caster)
        {
            target.TakeDamage(Damage);
        }
    }
}