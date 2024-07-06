using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsConsoleProject.Mediator_Pattern.ClassRoom
{
    internal class ClassRoom
    {
        public event EventHandler<ClassRoomEventArgs> ClassRoomChanging;
        public void Fire(ClassRoomEventArgs args)
        {
            ClassRoomChanging?.Invoke(this, args);  
        }
    }
}
