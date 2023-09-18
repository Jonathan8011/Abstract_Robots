using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_inc
{
    public class RobotQuad : RobotSpy
    {
        //1. עדכנו את הפעולה הבונה כך שתתאים לפעולת במחלקת העל
        public RobotQuad(string model, DateTime creationDate, double batteryStatus) : base(model, creationDate, batteryStatus)
        {

        }

        public override void MoveForward()
        {
            for (int i = 1; i < 5; i++)
                this.MoveLeg(i, 1);
            Console.WriteLine("RobotQuad Move Forward ------> ");
        }
        public override void MoveBackward()
        {
            for (int i = 1; i < 5; i++)
                this.MoveLeg(i, 1);
            Console.WriteLine("RobotQuad Move Backwaed  <------ ");
        }
        public override void TurnLeft()
        {
            for (int i = 1; i < 5; i++)
                this.MoveLeg(i, 1);
            Console.WriteLine("RobotQuad TurnLeft  <- ");
        }
        public override void TurnRight()
        {
            for (int i = 1; i < 5; i++)
                this.MoveLeg(i, 1);
            Console.WriteLine("RobotQuad TurnLeft  -> ");
        }



        private void MoveLeg(int legId, int dir) 
        {
            this.SetBattery(-5);
            
        }
    }

}
