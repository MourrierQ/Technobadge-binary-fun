using BinaryPuzzle.Model;
using Prism.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryPuzzle.UI.Event
{
    class OnClickEvent: PubSubEvent<OnClickEventArgs>
    {

    }

    public class OnClickEventArgs
    {
        public Cell Cell { get; set; }
    }
}
