using LanchesterLaw.Commands;
using LanchesterLaw.Models;
using LanchesterLaw.Stores;
using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace LanchesterLaw.ViewModels
{
    internal class LinearLanchesterLawViewModel : ViewModelBase
    {
        private uint _enemyCount = 0;
        public uint EnemyCount
        {
            get => _enemyCount;
            set
            {
                _enemyCount = value;
                OnPropertyChanged();
            }
        }
        private uint _allyCount = 0;
        public uint AllyCount
        {
            get => _allyCount;
            set
            {
                _allyCount = value;
                OnPropertyChanged();
            }
        }
        private uint _fortificationFactor = 1;
        public uint FortificationFactor
        {
            get => _fortificationFactor;
            set
            {
                _fortificationFactor = value;
                OnPropertyChanged();
            }
        }
        private uint _landscapeFactor=1;
        public uint LandscapeFactor
        {
            get => _landscapeFactor;
            set
            {
                _landscapeFactor = value;
                OnPropertyChanged();
            }
        }
        private uint _weatherFactor = 1;
        public uint WeatherFactor
        {
            get => _weatherFactor;
            set
            {
                _weatherFactor = value;
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
        public LinearLanchesterLawViewModel()
        {
            //SeriesCollection = new SeriesCollection
            //{
            //    new LineSeries
            //    {
            //        Title = "Оборона",
            //        Values = new ChartValues<double> { 4, 6, 5, 2 , 4 }
            //    },
            //    new LineSeries
            //    {
            //        Title = "Атака",
            //        Values = new ChartValues<double> { 6, 7, 3, 4 ,6 },
            //        PointGeometry = null
            //    }
            //};            
        }
        private RelayCommand _calculateCommand;
        public RelayCommand CalculateCommand
        {
            get
            {
                return _calculateCommand ?? new RelayCommand(obj =>
                {
                    var Lanchester = new LinearLanchesterLaw(_allyCount, _enemyCount, _fortificationFactor, _landscapeFactor, _weatherFactor);
                    /////////
                    SeriesCollection = new SeriesCollection()
                    {
                        
                        new LineSeries
                        {
                            Title = "Оборона",
                            Values = new ChartValues<int>(Lanchester.AllyCount)
                        },
                        new LineSeries
                        {
                            Title = "Атака",
                            Values = new ChartValues<int> (Lanchester.EnemyCount)
                        },
                    };
                    ///
                    MessageBox.Show(_fortificationFactor.ToString()+_landscapeFactor.ToString() +_weatherFactor.ToString());
                });
            }
        }
    }
}
