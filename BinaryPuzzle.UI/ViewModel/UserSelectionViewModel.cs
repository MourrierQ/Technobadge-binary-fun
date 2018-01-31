using BinaryPuzzle.UI.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryPuzzle.UI.ViewModel
{
    public class UserSelectionViewModel : ViewModelBase, IUserSelectionViewModel
    {
        public IUserLookupDataService _userLookupService;

        public ObservableCollection<UserSelectionItemViewModel> Users { get; }

        public UserSelectionViewModel(IUserLookupDataService userLookupService)
        {
            _userLookupService = userLookupService;
            Users = new ObservableCollection<UserSelectionItemViewModel>(); 
        }


        public async Task LoadAsync()
        {
            var lookup = await _userLookupService.GetUserLookupAsync();
            Users.Clear();

            foreach (var item in lookup)
            {
                Users.Add(new UserSelectionItemViewModel(item.Id, item.DisplayMember));
            }
        }
    }
}
