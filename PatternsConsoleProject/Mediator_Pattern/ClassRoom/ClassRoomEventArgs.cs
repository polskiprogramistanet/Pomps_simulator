using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsConsoleProject.Mediator_Pattern.ClassRoom
{
    internal abstract class ClassRoomEventArgs : EventArgs
    {
        public abstract void Print();
    }
}
