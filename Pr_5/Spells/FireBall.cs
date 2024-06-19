using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr_5.Spells
{
    public class FireBall : ISpell
    {
        public int Damage { get; } = 30;
        public int ManaCost { get; } = 10;

        public void CastSpell(IDamageble target, Mage caster)
        {
            target.TakeDamage(Damage);
        }
    }
}