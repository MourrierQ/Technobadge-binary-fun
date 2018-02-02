using BinaryPuzzle.Model;
using BinaryPuzzle.UI.Wrapper;
using Prism.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace BinaryPuzzle.UI.ViewModel
{
   public class TimerViewModel : ViewModelBase, ITimerViewModel
    {
        private IEventAggregator _eventAggregator;

        public TimerWrapper TimerWrapper = new TimerWrapper(new Timer());

        public static DispatcherTimer Dt = new DispatcherTimer();

        public string _time;

        public string Time {
            get { return _time; }
            set
            {
                if(value != null)_time = value;
                OnPropertyChanged();
            }
        }

        private double Increment;

        public TimerViewModel()
        {
            TimerWrapper = new TimerWrapper(new Timer());
        }

        public TimerViewModel(IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;
            
            Time = "0";
        }

        public void OnStartTimer()
        {
            Increment = 0;
            Time = "0";
            Dt.Tick -= dtTicker;
            Dt.Interval = TimeSpan.FromMilliseconds(3);
            
            Dt.Tick += dtTicker;
            Dt.Start();
        }

        public void OnStopTimer()
        {
            Dt.Stop();
        }

        private void dtTicker(object sender, EventArgs e)
        {
            Increment++;
            Time = (Math.Round((Increment/100),2)).ToString();
        }
    }
}
