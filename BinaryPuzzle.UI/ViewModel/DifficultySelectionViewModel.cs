using BinaryPuzzle.UI.Data;
using BinaryPuzzle.UI.Event;
using Prism.Commands;
using Prism.Events;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace BinaryPuzzle.UI.ViewModel
{
    public class DifficultySelectionViewModel : ViewModelBase, IDifficultySelectionViewModel
    {
        private IEventAggregator _eventAggregator;
        public IDifficultyLookupDataService _difficultyLookupService;

        public ObservableCollection<DifficultySelectionItemViewModel> Difficulties { get; }

        public DifficultySelectionViewModel(IDifficultyLookupDataService DifficultyLookupService, IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;
            _difficultyLookupService = DifficultyLookupService;
            Difficulties = new ObservableCollection<DifficultySelectionItemViewModel>();
            
        }

      

        public async Task LoadAsync()
        {
            var lookup = await _difficultyLookupService.GetDifficultyLookupAsync();
            Difficulties.Clear();

            foreach (var item in lookup)
            {
                Difficulties.Add(new DifficultySelectionItemViewModel(item.Id, item.DisplayMember, _eventAggregator));
            }
        }
    }
}
