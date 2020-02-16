using RogueGen.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueGen.Abilities
{
    public interface IAbility
    {
        string Name { get; set; }
        
        void Execute(IActor target);
        void Execute(IActor[] targets);
    }
}
