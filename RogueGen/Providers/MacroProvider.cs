using RogueGen.CombatMacro;
using RogueGen.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueGen.Providers
{
    public class MacroProvider : IMacroProvider
    {
        public IMacro GetMacro(MacroTypeEnum macroType)
        {
            switch (macroType)
            {
                case MacroTypeEnum.HealthGreaterEqual: break;
                case MacroTypeEnum.HealthLessEqual: break;
            }

            return null;
        }
    }
}
