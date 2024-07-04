using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatternsConsoleProject.Mediator_Pattern.ChatRoom;
using PatternsConsoleProject.Mediator_Pattern.ClassRoom;

namespace PatternsConsoleProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            var classRoom = new ClassRoom();
            var student = new Student(classRoom, "Rafael");
            var teacher = new Teacher(classRoom);

            student.MakeTaskDone();
            student.MakeTaskDone();
            student.MakeTaskDone();
            
            Console.ReadKey();
        }
    }
}
