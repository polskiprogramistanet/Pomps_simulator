using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsConsoleProject.Mediator_Pattern.ClassRoom
{
    internal class Teacher
    {
        private ClassRoom game;
        public Teacher(ClassRoom game)
        {
            this.game = game;

            game.ClassRoomChanging += (sender, args) =>
            {
                if(args is StudentDoneTaskEventArgs scored && scored.TaskDoneSoFar > 2)
                {
                    Console.WriteLine($"Teacher says: well done, {scored.StudentName}");
                }
            };
        }
    }
}
