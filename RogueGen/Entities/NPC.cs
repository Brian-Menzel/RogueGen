using RogueGen.Abilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueGen.Entities
{
    public class NPC : IActor
    {
        public NPC(List<IAbility> knownAbilities)
        {
            Abilities = knownAbilities;
        }

        public void BeforeAction()
        {
            //nothing
        }

        public void AfterAction()
        {
            //nothing
        }

        public int Health
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public int Magic
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public List<Abilities.IAbility> Abilities
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public List<Action<int, IActor, IActor, Abilities.IAbility>> CombatAIList
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }
}
