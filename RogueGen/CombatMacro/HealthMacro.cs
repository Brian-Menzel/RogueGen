using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueGen.CombatMacro
{
    public class HealthMacro : IMacro
    {
        public HealthMacro() { } //empty?

        public bool Evaluate()
        {
            return false;
        }

        public Func<Enums.ComparisonSymbolEnums, Enums.ConditionEnums, Entities.IActor, Entities.IActor, Abilities.IAbility, bool> MacroDelegate { get; set; }
       
    }
}
