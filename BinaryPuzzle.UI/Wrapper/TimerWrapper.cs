using BinaryPuzzle.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Threading;

namespace BinaryPuzzle.UI.Wrapper
{
    public class TimerWrapper : ModelWrapper<Timer>
    {
        public TimerWrapper(Timer model):base(model)
        {

        }

        

        public DispatcherTimer Dt
        {
            get { return GetValue<DispatcherTimer>(); }
            set {
                SetValue(value);
                OnPropertyChanged();
            }
        }

        public int Increment
        {
            get { return GetValue<int>(); }
            set
            {
                SetValue(value);
                OnPropertyChanged();
            }
        }

    }
}
