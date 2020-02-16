using RogueGen.Abilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueGen.Entities
{
    public interface IActor
    {

        int Health { get; set; }
        int Magic { get; set; }
        List<IAbility> Abilities {get; set;}
        List<Action<int, IActor, IActor, IAbility>> CombatAIList {get; set;}

        void BeforeAction();
        void AfterAction();

    }
}
