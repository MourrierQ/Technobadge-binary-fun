using BinaryPuzzle.Model;
using BinaryPuzzle.UI.Event;
using Prism.Commands;
using Prism.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BinaryPuzzle.UI.ViewModel
{
    public class GameGridItemViewModel : ViewModelBase
    {
        private string _displayMember;

        public Cell Cell { get; set; }

        public string DisplayMember
        {
            get { return _displayMember; }
            set
            {
                _displayMember = value;
                Cell.Bit = _displayMember;
                OnPropertyChanged();
            }
        }

        public GameGridItemViewModel(IEventAggregator eventAggregator)
        {
            Cell = new Cell();
            DisplayMember = "0";
            OnClickCommand = new DelegateCommand(OnClickHandler);
            _eventAggregator = eventAggregator;
        }

        private void OnClickHandler()
        {
            DisplayMember = DisplayMember == "0" ? "1" : "0";
            _eventAggregator.GetEvent<OnClickEvent>().Publish(new OnClickEventArgs { Cell = Cell });
        }

        public ICommand OnClickCommand { get; }

        private IEventAggregator _eventAggregator;
    }
}
