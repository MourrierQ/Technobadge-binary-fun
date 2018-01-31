using BinaryPuzzle.Model;
using BinaryPuzzle.UI.Event;
using BinaryPuzzle.UI.Wrapper;
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
    public class GameGridViewModel : ViewModelBase, IGameGridViewModel
    {
        public ObservableCollection<GameGridItemViewModel> Cells { get; set; }
        public ObservableCollection<ResultBoxWrapper> HorizontalTargets { get; set; }
        public ObservableCollection<ResultBoxWrapper> VerticalTargets { get; set; }

        public int cellSize { get; private set; }
        public int fontSize { get; private set; }
        public int resFontSize { get; private set; }


        private IEventAggregator _eventAggregator;
        private static Random rnd;

        public GameGridViewModel()
        {

        }

        public GameGridViewModel(IEventAggregator eventAggregator)
        {
            Cells = new ObservableCollection<GameGridItemViewModel>();
            HorizontalTargets = new ObservableCollection<ResultBoxWrapper>();
            VerticalTargets = new ObservableCollection<ResultBoxWrapper>();
            
            _eventAggregator = eventAggregator;
            
            rnd = new Random();
        }

       

        public void GenerateGrid(GenerateGridEventArgs args)
        {
             int n = 0;
            switch (args.DifficultyName)
            {
                case "Easy":
                    n = 4;
                    cellSize = 50;
                    fontSize = 22;
                    resFontSize = 22;
                    break;
                case "Normal":
                    n = 6;
                    cellSize = 32;
                    fontSize = 20;
                    resFontSize = 18;
                    break;
                case "Expert":
                    n = 8;
                    cellSize = 23;
                    fontSize = 14;
                    resFontSize = 7;
                    break;
                default:
                    break;
            }
            Cells.Clear();
            HorizontalTargets.Clear();
            VerticalTargets.Clear();
            InitializeResults(n);
            InitializeCells(n);
            LinkCellsToResults(n);
            for (int i = 0; i < Cells.Count; i++)
            {
                Cells[i].Cell.Bit = "0";
            }
        }

        

        private void LinkCellsToResults(int n)
        {
            int nCells = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Cells[nCells].Cell.HorizontalTarget = HorizontalTargets[i].Model;
                    Cells[nCells].Cell.VerticalTarget = VerticalTargets[j].Model;
                    HorizontalTargets[i].Result += int.Parse(Cells[nCells].Cell.Bit) * Cells[nCells].Cell.HorizontalValue; 
                    VerticalTargets[j].Result += int.Parse(Cells[nCells].Cell.Bit) * Cells[nCells].Cell.VerticalValue;
                    nCells++;
                }
            }
        }

        private void InitializeResults(int n)
        {
            for (int i = 0; i < n; i++)
            {
                VerticalTargets.Add(new ResultBoxWrapper (new ResultBox { FontSize = resFontSize, Size= cellSize, Status = "#6D4C41" }));
                HorizontalTargets.Add(new ResultBoxWrapper (new ResultBox{ FontSize = resFontSize, Size = cellSize, Status = "#6D4C41" }));
            }
        }

        private void InitializeCells(int n)
        {
            double horizontalValue;
            double verticalValue;
            for (int i = 0; i < n; i++)
            {
                horizontalValue = Math.Pow(2, n-1);
                verticalValue = Math.Pow(2, n - 1 - i);
                for (int j = 0; j < n; j++)
                {
                    string bit = rnd.Next(0, 2).ToString();
                    Cell tempCell = new Cell
                    {
                        FontSize = fontSize,
                        Size = cellSize,
                        Bit = bit,
                        HorizontalValue = horizontalValue,
                        VerticalValue = verticalValue
                    };
                    GameGridItemViewModel temp = new GameGridItemViewModel(_eventAggregator);
                    temp.Cell = tempCell;
                    Cells.Add(temp);
                    
                    
                    horizontalValue = horizontalValue / 2;
                }
                
            }
        }

        public void OnClick(OnClickEventArgs obj)
        {
            
            var cellsH = Cells.Where(c => c.Cell.HorizontalTarget == obj.Cell.HorizontalTarget);
            var cellsV = Cells.Where(c => c.Cell.VerticalTarget == obj.Cell.VerticalTarget);

            double VRes = 0;
            double HRes = 0;
            foreach (var item in cellsH)
            {
                HRes += int.Parse(item.Cell.Bit) * item.Cell.HorizontalValue; 
            }
            foreach (var item in cellsV)
            {
                VRes += int.Parse(item.Cell.Bit) * item.Cell.VerticalValue;
            }
            var HTarget = HorizontalTargets.Single(c => obj.Cell.HorizontalTarget == c.Model);
            var VTarget = VerticalTargets.Single(c => obj.Cell.VerticalTarget == c.Model);
            

            HTarget.Status = HTarget.Result == HRes ? "#30D1D5" : "#6D4C41";
            VTarget.Status = VTarget.Result == VRes ? "#30D1D5" : "#6D4C41";

        }
    }
}
