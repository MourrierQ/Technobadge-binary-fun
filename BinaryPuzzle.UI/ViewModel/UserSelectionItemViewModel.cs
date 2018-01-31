using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryPuzzle.UI.ViewModel
{
    public class UserSelectionItemViewModel : ViewModelBase
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

        public UserSelectionItemViewModel(int id, string displayMember)
        {
            DisplayMember = displayMember;
            Id= id;
        }

    }
}
