using BinaryPuzzle.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryPuzzle.UI.Wrapper
{
    public class CellWrapper : ModelWrapper<Cell>
    {
        public CellWrapper(Cell model):base(model)
        {

        }

        public string Bit
        {
            get
            {
                return GetValue<string>();
            }
            set
            {
                SetValue(value);
                OnPropertyChanged();
            }
        }



        public double HorizontalValue
        {
            get
            {
                return GetValue<double>();
            }
            set
            {
                SetValue(value);
                OnPropertyChanged();  
            }
        }

        public double VerticalValue
        {
            get
            {
                return GetValue<double>();
            }
            set
            {
                SetValue(value);
                OnPropertyChanged();
            }
        }

        public ResultBox HorizontalTarget
        {
            get
            {
                return GetValue<ResultBox>();
            }
            set
            {
                SetValue(value);
                OnPropertyChanged();
            }
        }

        public ResultBox VerticalTarget
        {
            get
            {
                return GetValue<ResultBox>();
            }
            set
            {
                SetValue(value);
                OnPropertyChanged();
            }
        }
    }
}
