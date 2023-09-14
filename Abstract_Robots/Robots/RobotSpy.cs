﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_inc
{
	public abstract class RobotSpy
	{
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
        public string GetModel() { return this.model; }
        public DateTime GetcreationDate() { return this.creationDate; }

        public double GetBattery() { return this.batteryStatus; }
        public void SetBattery(double value) { this.batteryStatus = value; }
		

		public abstract void MoveForward();
		public abstract void MoveBackward();
		public abstract void TurnLeft();
		public abstract void TurnRight();

		public void TakePicture()
		{ 
			Console.WriteLine("Takeing Picture (*^▽^*)");
			SetBattery(this.batteryStatus - 5);
		} 
		public void ChargeBattery() { SetBattery(100); } //5. עדכנו את מצב הסוללה ל-100
	}
}
