// Access to standard .NET System
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
// Access to the public Robocode API
using Robocode;

namespace RobocodeExample
{
    // The name of your robot is MyRobot, and the robot type is Robot
    class MyRobot : Robot
    {
        // The main method of your robot containing robot logics
        public override void Run()
        {
            // Here we turn the robot to point upwards, and move the gun 90 degrees
            TurnLeft(Heading - 90);
            TurnGunRight(90);

            // Infinite loop making sure this robot runs till the end of the battle round
            while (true)
            {
                // Move our robot 5000 pixels ahead
                Ahead(5000);
                // Turn the robot 90 degrees
                TurnRight(90);
            }
        }

        // Robot event handler, when the robot sees another robot
        public override void OnScannedRobot(ScannedRobotEvent e)
        {
            // We fire the gun with bullet power = 1
            Fire(1);
        }
    }
}
