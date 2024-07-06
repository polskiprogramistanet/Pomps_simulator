using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsConsoleProject.Mediator_Pattern.ClassRoom
{
    internal class StudentDoneTaskEventArgs : ClassRoomEventArgs
    {
        public string StudentName { get; private set; }
        public int TaskDoneSoFar { get; private set; }
        public StudentDoneTaskEventArgs(string studentName, int taskDoneSoFar)
        {
            StudentName = studentName;
            TaskDoneSoFar = taskDoneSoFar;
        }

        public override void Print()
        {
            Console.WriteLine($"{StudentName} done task! (this is thier {TaskDoneSoFar} task)");
        }
    }
}
