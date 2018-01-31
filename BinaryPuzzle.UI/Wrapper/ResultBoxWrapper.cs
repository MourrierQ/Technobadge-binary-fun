using BinaryPuzzle.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryPuzzle.UI.Wrapper
{
    public class ResultBoxWrapper : ModelWrapper<ResultBox>
    {
        public ResultBoxWrapper(ResultBox model) : base(model)
        {

        }

        public double Result
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

        public int Size
        {
            get
            {
                return GetValue<int>();
            }
            set
            {
                SetValue(value);
                OnPropertyChanged();
            }
        }

        public int FontSize
        {
            get
            {
                return GetValue<int>();
            }
            set
            {
                SetValue(value);
                OnPropertyChanged();
            }
        }



        public string Status
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


    }
}
