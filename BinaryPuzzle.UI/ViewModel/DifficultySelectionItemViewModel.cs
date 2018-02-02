using BinaryPuzzle.UI.Event;
using Prism.Commands;
using Prism.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace BinaryPuzzle.UI.ViewModel
{
    public class DifficultySelectionItemViewModel : ViewModelBase
    {
        private string _displayMember;

        public int Id { get; }

        public string DisplayMember
        {
            get { return _displayMember; }
            set
            {
                _displayMember = value;
                OnPropertyChanged();
            }
        }

        public DifficultySelectionItemViewModel(int id, string displayMember, IEventAggregator eventAggregator)
        {
            DisplayMember = displayMember;
            Id = id;
            GenerateGameGridCommand = new DelegateCommand(GenerateGrid);
            _eventAggregator = eventAggregator;
        }

        private void GenerateGrid()
        {
            _eventAggregator.GetEvent<GenerateGridEvent>().Publish(new GenerateGridEventArgs { DifficultyName = DisplayMember});
            _eventAggregator.GetEvent<OnStartTimerEvent>().Publish(new OnStartTimerEventArgs());
        }

        public ICommand GenerateGameGridCommand { get; }

        private IEventAggregator _eventAggregator;
    }
}
