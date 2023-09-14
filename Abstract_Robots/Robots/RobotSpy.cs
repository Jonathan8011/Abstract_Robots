using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_inc
{
	public abstract class RobotSpy
	{
		private int new123;
		private string model;
		private DateTime creationDate;
		private double batteryStatus; 

		//1. פעולה בונה
		public RobotSpy(string model , DateTime creationDate , double batteryStatus)
		{
			this.model = model;
			this.creationDate = creationDate;
			this.batteryStatus = batteryStatus;
		}
		public string Model() { return this.model; }
		public DateTime CreationDate() { return creationDate; }
		public double BatteryStatus { get { return batteryStatus; } set { batteryStatus = value; } }
		

		public abstract void MoveForward();
		public abstract void MoveBackward();
		public abstract void TurnLeft();
		public abstract void TurnRight();

		public void TakePicture() { } //4. הוסיפו התייחסות למצב סוללה
		public void ChargeBattery() { } //5. עדכנו את מצב הסוללה ל-100
	}
}
