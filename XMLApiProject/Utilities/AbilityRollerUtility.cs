using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XMLApiProject.Utilities
{
    public static class AbilityRollerUtility
    {
        public static int RollAbility()
        {
            var random = new Random();
            var score = 0;
            var min = int.MaxValue;
            for(int i = 0; i < 4; ++i)
            {
                var roll = random.Next(1, 6);
                min = min > roll ? roll : min;
                score += roll;
            }
            return score - min;
        }
    }
}
