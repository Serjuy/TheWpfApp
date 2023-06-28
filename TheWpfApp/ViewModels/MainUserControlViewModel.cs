using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;
using TheWpfApp.Models;

namespace TheWpfApp.ViewModels
{
    public class MainUserControlViewModel : INotifyPropertyChanged
    {
        private DispatcherTimer timer;
        private PersonalInfo _Info = new PersonalInfo();

        public PersonalInfo Info
        {
            get { return _Info; }
            set
            {
                _Info = value;
                OnPropertyChanged("Info");
            }

        }
        public MainUserControlViewModel()
        {
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Timer_Tick;
            timer.Start();
        }
        private string _Time;

        public string Time
        {
            get { return _Time; }
            set
            {
                _Time = value;
                OnPropertyChanged("Time");
            }
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            Time = DateTime.Now.ToLongTimeString();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

    }
}
