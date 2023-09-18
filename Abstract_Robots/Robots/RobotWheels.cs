using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_inc
{
    public class RobotWheels : RobotSpy
    {
        public RobotWheels(string model, DateTime creationDate, double batteryStatus) : base(model, creationDate, batteryStatus)
        {

        }
        public override void MoveForward()
        {
            for (int i = 1; i < 7; i++)
                this.MoveLeg(i, 1);
            Console.WriteLine("RobotFly Move Forward ------> ");
        }
        public override void MoveBackward()
        {
            for (int i = 1; i < 7; i++)
                this.MoveLeg(i, 1);
            Console.WriteLine("RobotFly Move Backwaed  <------ ");
        }
        public override void TurnLeft()
        {
            for (int i = 1; i < 7; i++)
                this.MoveLeg(i, 1);
            Console.WriteLine("RobotFly TurnLeft  <- ");
        }
        public override void TurnRight()
        {
            for (int i = 1; i < 7; i++)
                this.MoveLeg(i, 1);
            Console.WriteLine("RobotFly TurnRight  -> ");
        }

        public void MoveLeftArm()
        {
            for (int i = 0; i < 1; i++)
                this.MoveArm(i, 1);
            Console.WriteLine("RobotFly Move Left Arm  <<< ");
        }

        public void MoveRightArm()
        {
            for (int i = 1; i < 2; i++)
                this.MoveArm(i, 1);
            Console.WriteLine("RobotFly Move Right Arm  >>> ");
        }





        private void MoveLeg(int legId, int dir)
        {
            this.SetBattery(-4.5);

        }

        private void MoveArm(int ArmId, int dir)
        {
            this.SetBattery(2);
        }

    }
}
