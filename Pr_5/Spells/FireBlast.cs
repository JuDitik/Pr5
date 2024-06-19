using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr_5.Spells
{
    public class FireBlast : ISpell
    {
        public int Damage { get; } = 40;
        public int ManaCost { get; } = 15;

        public void CastSpell(IDamageble target, Mage caster)
        {
            target.TakeDamage(Damage);
        }
    }
}