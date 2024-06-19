using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr_5
{
    public interface ISpell
    {
        int Damage { get; }
        int ManaCost { get; }
        void CastSpell(IDamageble target, Mage caster);
    }
}