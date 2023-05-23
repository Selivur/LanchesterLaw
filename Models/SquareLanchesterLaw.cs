using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanchesterLaw.Models
{
    internal class SquareLanchesterLaw
    {
        public int[] AllyCount { get; }
        public int[] EnemyCount { get; }
        private int _length = 50;
        public SquareLanchesterLaw(uint allyCount, uint allyUnitSquare, uint allySquare, uint allyPower, uint enemyCount, uint enemyUnitSquare, uint enemySquare, uint enemyPower)
        {
            AllyCount = new int[_length];
            EnemyCount = new int[_length];
            AllyCount[0] = (int)allyCount;
            EnemyCount[0] = (int)enemyCount;
            for (int i = 1; i < _length; i++)
            {
                double AllyCoef = (double)allyPower* (double)allyUnitSquare / (double)allySquare;
                double EnemyCoef = (double)enemyPower * (double)enemyUnitSquare / (double)enemySquare;
                AllyCount[i] = (AllyCount[i - 1] - (int)(Convert.ToDouble(EnemyCount[i - 1]) * AllyCoef)) >= 0 ? ((AllyCount[i - 1] - (int)(Convert.ToDouble(EnemyCount[i - 1]) * AllyCoef))) : (0);
                EnemyCount[i] = (EnemyCount[i - 1] - (int)(Convert.ToDouble(AllyCount[i - 1]) * EnemyCoef)) >= 0 ? (EnemyCount[i - 1] - (int)(Convert.ToDouble(AllyCount[i - 1]) * EnemyCoef)) : (0);
            }
        }
    }
}
