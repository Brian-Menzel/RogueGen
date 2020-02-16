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
    public class CombatDelegates
    {
        public static Func<ComparisonSymbolEnums, ConditionEnums, IActor, IActor, IAbility, bool> TargetHealthLessThan = _targetHealth;
        //public static Action<ConditionEnums, IActor, IActor, IAbility> TargetHealthGreaterThan = _targetHealthGreaterThan;
        //public static Action<ConditionEnums, IActor, IActor, IAbility> SelfHealthLessThan = _selfHealthLessThan;

        private static bool _targetHealth(ComparisonSymbolEnums symbol, ConditionEnums threshold, IActor target, IActor caster, IAbility abilityUsed)
        {
            switch (symbol)
            {
                case ComparisonSymbolEnums.GreaterThan:
                    {
                        return _greaterThan(threshold, target.Health);
                    }
                case ComparisonSymbolEnums.GreaterThanEqual:
                    {
                        return _greaterThanEqual(threshold, target.Health);
                    }
                case ComparisonSymbolEnums.LessThan:
                    {
                        return _lessThan(threshold, target.Health);
                    }
                case ComparisonSymbolEnums.LessThanEqual:
                    {
                        return _lessThanEqual(threshold, target.Health);
                    }
                case ComparisonSymbolEnums.Equal:
                    {
                        return _equal(threshold, target.Health);
                    }
                default: return false;
            }

            return false;
        }

        //private static bool _targetHealthGreaterThan(ConditionEnums threshold, IActor target, IActor caster, IAbility abilityUsed)
        //{
        //    if (target.Health > threshold)
        //    {
        //        caster.BeforeAction();
        //        abilityUsed.Execute(target);
        //        caster.AfterAction();
        //    }
        //}

        //private static bool _selfHealthLessThan(ConditionEnums threshold, IActor target, IActor caster, IAbility abilityUsed)
        //{
        //    if (caster.Health < threshold)
        //    {
        //        caster.BeforeAction();
        //        abilityUsed.Execute(target);
        //        caster.AfterAction();
        //    }
        //}

        private static bool _greaterThan(ConditionEnums threshold, int value)
        {
            switch (threshold)
            {
                case ConditionEnums.Zero: return value > 0;
                case ConditionEnums.Fifteen: return value > 15;
                case ConditionEnums.TwentyFive: return value > 25;
                case ConditionEnums.Fifty: return value > 50;
                case ConditionEnums.SeventyFive: return value > 75;
                case ConditionEnums.OneHundred: return value > 100;
                default: return false;
            }
        }

        private static bool _greaterThanEqual(ConditionEnums threshold, int value)
        {
            switch (threshold)
            {
                case ConditionEnums.Zero: return value >= 0;
                case ConditionEnums.Fifteen: return value >= 15;
                case ConditionEnums.TwentyFive: return value >= 25;
                case ConditionEnums.Fifty: return value >= 50;
                case ConditionEnums.SeventyFive: return value >= 75;
                case ConditionEnums.OneHundred: return value >= 100;
                default: return false;
            }
        }

        private static bool _lessThan(ConditionEnums threshold, int value)
        {
            switch (threshold)
            {
                case ConditionEnums.Zero: return value < 0;
                case ConditionEnums.Fifteen: return value < 15;
                case ConditionEnums.TwentyFive: return value < 25;
                case ConditionEnums.Fifty: return value < 50;
                case ConditionEnums.SeventyFive: return value < 75;
                case ConditionEnums.OneHundred: return value < 100;
                default: return false;
            }
        }

        private static bool _lessThanEqual(ConditionEnums threshold, int value)
        {
            switch (threshold)
            {
                case ConditionEnums.Zero: return value <= 0;
                case ConditionEnums.Fifteen: return value <= 15;
                case ConditionEnums.TwentyFive: return value <= 25;
                case ConditionEnums.Fifty: return value <= 50;
                case ConditionEnums.SeventyFive: return value <= 75;
                case ConditionEnums.OneHundred: return value <= 100;
                default: return false;
            }
        }

        private static bool _equal(ConditionEnums threshold, int value)
        {
            switch (threshold)
            {
                case ConditionEnums.Zero: return value == 0;
                case ConditionEnums.Fifteen: return value == 15;
                case ConditionEnums.TwentyFive: return value == 25;
                case ConditionEnums.Fifty: return value == 50;
                case ConditionEnums.SeventyFive: return value == 75;
                case ConditionEnums.OneHundred: return value == 100;
                default: return false;
            }
        }



    }
}

