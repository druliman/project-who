using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
	class Program
	{
		static void Main(string[] args)
		{
			//создать 5 классов разных транспортных средств каждый класс должен состоять из 4 характеристики и 2 метода

		}
	}
	class Bike : Transport
	{
		//string ;
		bool pedals = false;
		Turn turn = Turn.straight;

		public Turn TurnBike()
		{
			Console.WriteLine("Введите в какую сторону вы собрались ехать(=>,<=)");
			string t = Console.ReadLine();
			if (t == "=>")
			{
				return turn = Turn.right;
			}
			else return turn = Turn.left;
		}
		public bool start()
		{
			return pedals = true;
		}
		public Bike(int speed, string wheels) : base(speed, wheels)
		{

		}
		public override  int move()
		{
			if (pedals == true)
			{
				Transport b = new Transport(20, "кОЛЁсики крутяться");
				wheels = "Колёса крутятся";
				speed += 5;
				Console.WriteLine(wheels);
				return speed;
			}
			else { speed = 0; return speed; }
		}
		public bool finish()
		{
			return pedals = false;
		}
		public enum Turn
		{
			left,
			right,
			straight
		}
	}
	class ElestricScooter : Transport
	{
		bool button = false;
		bool Brake = true;
		double charge = 100;

		public ElestricScooter(int speed, string wheels):base(speed,wheels)
		{

		}
		public void start()
		{
		    button = true;
			Brake = false;
			charge -= 0.0000001;
		}
		public void Stop()
		{
			Brake = true;
		}
		public override int move()
		{
			if (button == true)
			{
				int boost = 10;
				int time = 2;
			    charge -= 0.5;
				Console.WriteLine(wheels+" "+speed);
			}
			return 0;
		}
	}
	class Transport
	{
		protected int speed;
		protected string wheels;
		public virtual int move()
		{
			int g = 1;
			//Тут что-то былооооооооооооооооооооооооооооооооооо
			return g;
		}
		public Transport(int speed, string wheels)
		{
			this.speed = speed;
			this.wheels = wheels;
		}
	}
}
