package NFSA;
// Access to the public Robocode API
import robocode.*;

// Says the object I'm describing here is a type of Robot, named RobotTest
public class RobotTest extends Robot
{
    // The game calls your run() method when the battle begins.
	public void run() {
        // Infinite loop making sure this robot runs till the end of the battle round
        while (true) {
            // Move our robot 100 pixels ahead
            ahead(100);
            //Turn the gun 360 degrees to the right
            turnGunRight(360);
            // Move our robot 100 pixels back
            back(100);
            // Turn the gun 360 degrees to the right
            turnGunRight(360);
        }
    }

    // Robot event handler, when the robot sees another robot
    public void onScannedRobot(ScannedRobotEvent e) {
        // We fire the gun with bullet power = 1
        fire(1);
    }
}
