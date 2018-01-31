using Prism.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryPuzzle.UI.Event
{
    public class GenerateGridEvent : PubSubEvent<GenerateGridEventArgs>
    {
    }

    public class GenerateGridEventArgs
    {
        public string DifficultyName { get; set; }
    }
}
