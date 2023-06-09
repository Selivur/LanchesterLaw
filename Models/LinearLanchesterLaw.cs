﻿using System;
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
        private int _length=100;
        public LinearLanchesterLaw(uint ally, uint enemy, uint ff, uint landscape, uint weather)
        {
            AllyCount = new int[_length];
            EnemyCount = new int[_length];
            AllyCount[0] = (int)ally;
            EnemyCount[0] = (int)enemy;            
            for (int i = 1;i < _length; i++)
            {
                double AllyCoef = 0.02 * landscape * 0.1 * weather * 0.1 * 0.8 * ff * 0.1;
                double EnemyCoef = 0.02 * landscape * 0.1 * weather * 0.1;
                AllyCount[i] = (AllyCount[i - 1] - (int)(Convert.ToDouble(EnemyCount[i - 1]) * AllyCoef)) >= 0 ? ((AllyCount[i - 1] - (int)(Convert.ToDouble(EnemyCount[i - 1]) * AllyCoef))) : (0);
                EnemyCount[i] = (EnemyCount[i - 1] - (int)(Convert.ToDouble(AllyCount[i - 1]) * EnemyCoef)) >= 0 ? (EnemyCount[i - 1] - (int)(Convert.ToDouble(AllyCount[i - 1]) * EnemyCoef)) : (0);
            }
        }
    }
}
