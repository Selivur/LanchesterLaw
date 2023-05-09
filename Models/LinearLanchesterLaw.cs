using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanchesterLaw.Models
{
    internal class LinearLanchesterLaw
    {
        public int[] AllyCount { get; }
        public int[] EnemyCount { get; }
        public LinearLanchesterLaw(uint ally, uint enemy, uint ff, uint landscape, uint weather)//TODO add fortfact+learn about k5
        {
            AllyCount = new int[50];
            EnemyCount = new int[50];
            AllyCount[0] = (int)ally;
            EnemyCount[0] = (int)enemy;            
            for (int i = 1;i < 50; i++)
            {
                double AllyCoef = 0.02 * landscape * 0.1 * weather * 0.1 * 0.8;
                double EnemyCoef = 0.02 * landscape * 0.1 * weather * 0.1;
                AllyCount[i] = (AllyCount[i - 1] - (int)(Convert.ToDouble(EnemyCount[i - 1]) * AllyCoef)) >= 0 ? ((AllyCount[i - 1] - (int)(Convert.ToDouble(EnemyCount[i - 1]) * AllyCoef))) : (0);
                EnemyCount[i] = (EnemyCount[i - 1] - (int)(Convert.ToDouble(AllyCount[i - 1]) * EnemyCoef)) >= 0 ? (EnemyCount[i - 1] - (int)(Convert.ToDouble(AllyCount[i - 1]) * EnemyCoef)) : (0);
            }
        }
    }
}
