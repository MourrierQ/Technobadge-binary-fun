using System.Collections.ObjectModel;
using System.Windows.Input;
using BinaryPuzzle.Model;
using BinaryPuzzle.UI.Event;
using BinaryPuzzle.UI.Wrapper;

namespace BinaryPuzzle.UI.ViewModel
{
    public interface IGameGridViewModel
    {
        ObservableCollection<GameGridItemViewModel> Cells { get; set; }
        
        ObservableCollection<ResultBoxWrapper> HorizontalTargets { get; set; }
        ObservableCollection<ResultBoxWrapper> VerticalTargets { get; set; }
        void GenerateGrid(GenerateGridEventArgs args);
        void OnClick(OnClickEventArgs obj);
    }
}