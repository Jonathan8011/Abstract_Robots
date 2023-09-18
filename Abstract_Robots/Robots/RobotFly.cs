using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_inc
{
    //כתבו את המחלקה על פי המחלקות הקודמות
    //שימו לב שעליכם להתייחס גם לתעופה
    class RobotFly : RobotSpy
    {
        //1. עדכנו את הפעולה הבונה כך שתתאים לפעולת במחלקת העל
        public RobotFly(string model, DateTime creationDate, double batteryStatus) : base(model, creationDate, batteryStatus)
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

        public  void MoveUp()
        {
            for (int i = 1; i < 3; i++)
                this.MoveWings(i, 1);
            Console.WriteLine("RobotFly Move Up  +++ ");
        }

        public void MoveDown()
        {
            for (int i = 1; i < 3; i++)
                this.MoveWings(i, 1);
            Console.WriteLine("RobotFly Move Down --- ");
        }





        private void MoveLeg(int legId, int dir)
        {
            this.SetBattery(-4.5);

        }

        private void MoveWings(int ArmId, int dir)
        {
            this.SetBattery(-1.5);
        }
    }
}
