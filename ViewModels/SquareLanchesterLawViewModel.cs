using LanchesterLaw.Commands;
using LanchesterLaw.Models;
using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace LanchesterLaw.ViewModels
{
    internal class SquareLanchesterLawViewModel : ViewModelBase
    {
        private uint _allyCount = 1;
        public uint AllyCount
        {
            get => _allyCount;
            set
            {
                _allyCount = value;
                OnPropertyChanged();
            }
        }
        private uint _enemyCount = 1;
        public uint EnemyCount
        {
            get => _enemyCount;
            set
            {
                _enemyCount = value;
                OnPropertyChanged();
            }
        }
        private uint _allyUnitSquare = 1;
        public uint AllyUnitSquare
        {
            get => _allyUnitSquare;
            set
            {
                _allyUnitSquare = value;
                OnPropertyChanged();
            }
        }
        private uint _allySquare = 1;
        public uint AllySquare
        {
            get => _allySquare;
            set
            {
                _allySquare = value;
                OnPropertyChanged();
            }
        }
        private uint _allyUnitPower = 1;
        public uint AllyUnitPower
        {
            get => _allyUnitPower;
            set
            {
                _allyUnitPower = value;
                OnPropertyChanged();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        private uint _enemyUnitSquare = 1;
        public uint EnemyUnitSquare
        {
            get => _enemyUnitSquare;
            set
            {
                _enemyUnitSquare = value;
                OnPropertyChanged();
            }
        }
        private uint _enemySquare = 1;
        public uint EnemySquare
        {
            get => _enemySquare;
            set
            {
                _enemySquare = value;
                OnPropertyChanged();
            }
        }
        private uint _enemyUnitPower = 1;
        public uint EnemyUnitPower
        {
            get => _enemyUnitPower;
            set
            {
                _enemyUnitPower = value;
                OnPropertyChanged();
            }
        }
        public SeriesCollection _seriesCollection;
        public SeriesCollection SeriesCollection
        {
            get => _seriesCollection;
            set
            {
                _seriesCollection = value;
                OnPropertyChanged();
            }
        }
        public string[] Labels { get; set; }
        public Func<double, string> YFormatter { get; set; }

        private RelayCommand _calculateCommand;
        public RelayCommand CalculateCommand
        {
            get
            {
                return _calculateCommand ?? new RelayCommand(obj =>
                {
                    if (_allyCount == 0 || _allyUnitSquare == 0 || _allySquare == 0 || _allyUnitPower == 0 || _enemyCount == 0 || _enemyUnitSquare == 0 || _enemySquare == 0 || _enemyUnitPower == 0)
                    {
                        MessageBox.Show("Перевірте параметри. Серед них не має бути 0");
                    }
                    else
                    {
                        var Lanchester = new SquareLanchesterLaw(_allyCount, _allyUnitSquare, _allySquare, _allyUnitPower, _enemyCount, _enemyUnitSquare, _enemySquare, _enemyUnitPower);
                        /////////
                        SeriesCollection = new SeriesCollection()
                        {
                            new LineSeries
                            {
                                Title = "Сторона 1",
                                Values = new ChartValues<int>(Lanchester.AllyCount),
                                PointGeometry = null
                            },
                            new LineSeries
                            {
                                Title = "Сторона 2",
                                Values = new ChartValues<int> (Lanchester.EnemyCount),
                                PointGeometry = null
                            },
                        };
                    }
                });
            }
        }
    }
}
