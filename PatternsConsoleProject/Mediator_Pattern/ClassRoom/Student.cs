using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsConsoleProject.Mediator_Pattern.ClassRoom
{
    internal class Student
    {
        private string name;
        private int taskDone = 0;
        private ClassRoom classRoom; 
        public Student(ClassRoom classRoom, string name)
        {
            this.classRoom = classRoom;
            this.name = name;
        }

        public void MakeTaskDone()
        {
            taskDone++;
            var args = new StudentDoneTaskEventArgs(name, taskDone);
            classRoom.Fire(args);
        }
    }
}
