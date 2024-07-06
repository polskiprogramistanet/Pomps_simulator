﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stateless;

namespace StateExample
{
    class Program
    {/// <summary>
     /// This example has a simple state machine with only two states. The state
     /// information is of type string, and the type of the trigger is char. 
     /// </summary>
        static void Main(string[] args)
        {
            const string on = "On";
            const string off = "Off";
            const char space = ' ';

            // Instantiate a new state machine in the 'off' state
            var onOffSwitch = new StateMachine<string, char>(off);
            // Configure state machine with the Configure method, supplying the state to be configured as a parameter
            onOffSwitch.Configure(off).Permit(space, on);
            onOffSwitch.Configure(on).Permit(space, off);

            Console.WriteLine("Press <space> to toggle the switch. Any other key will exit the program.");
            var diagram =  Stateless.Graph.UmlDotGraph.Format(onOffSwitch.GetInfo());
            while (true)
            {
                Console.WriteLine("Switch is in state: " + onOffSwitch.State);
                var pressed = Console.ReadKey(true).KeyChar;

                // Check if user wants to exit
                if (pressed != space) break;

                // Use the Fire method with the trigger as payload to supply the state machine with an event.
                // The state machine will react according to its configuration.
                onOffSwitch.Fire(pressed);
            }
        }
    }
}
