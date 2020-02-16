using RogueGen.CombatMacro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RogueGen.Enums;

namespace RogueGen.Providers
{
    public interface IMacroProvider
    {
        IMacro GetMacro(MacroTypeEnum macroType);
    }
}
