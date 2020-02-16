using RogueGen.Abilities;
using RogueGen.Entities;
using RogueGen.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueGen.CombatMacro
{
    public interface IMacro
    {
        bool Evaluate();
        Func<ComparisonSymbolEnums, ConditionEnums, IActor, IActor, IAbility, bool> MacroDelegate { get; set; }
    }
}
