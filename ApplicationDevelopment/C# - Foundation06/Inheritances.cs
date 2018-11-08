using System;
using System.Collections.Generic;
using System.Text;

namespace IntroCore
{
	class Inheritances
	{
		public static void Display()
		{
			// (1) - base class
			//Vehicle vehicle = new Vehicle("honda", "civic", 12345);
			Console.WriteLine("** create default motocycle");
			Motocycle m1 = new Motocycle();
			
			Console.WriteLine("** create honda motocycle");
			Motocycle motocycle = new Motocycle("honda", "ninja", 12345, true);
			Console.WriteLine("** create seabreeze boat");
			Boat boat = new Boat("seabreeze", "lightning", 54321);

			motocycle.DisplayInfo();
			boat.DisplayInfo();

			// (2) - polymorphism
			// Using the base class as the type, the objects can be treated as a homogeneous group.
			// The objects all share the same base type
			List<Vehicle> vehicles = new List<Vehicle>() { m1, motocycle, boat };
			foreach (Vehicle v in vehicles)
			{
				v.PayRegistration(30.0f);
				if (v is Boat)
				{
					Console.WriteLine("Boat found.");
				}
			}

			// cast from the derived class to the base class
			Vehicle vehicle = (Vehicle)motocycle;
			vehicle.DisplayInfo();
			vehicle.PayRegistration(23.0f);

			// (3) - nested types			
			Course course = new Course(4);
			// To access the inner type (outer type.inner type)
			Course.Student student = new Course.Student();
		}
	}

	/// <summary>
	/// The abstract modifier indicates that the thing being modified has a missing or incomplete implementation. 
	/// The abstract modifier can be used with classes, methods, properties, indexers, and events. 
	/// Use the abstract modifier in a class declaration to indicate that a class is intended only 
	/// to be a base class of other classes. 
	/// Members marked as abstract, or included in an abstract class, must be implemented by classes 
	/// that derive from the abstract class.
	/// </summary>
	public abstract class Vehicle //abstract means never make an instance
	{
		protected string Make { get; set; }
		protected string Model { get; set; }
		private int License { get; set; }
		public bool IsRegistered { get; set; } = false;
		
		public Vehicle()
		{
			Console.WriteLine("Default Vehicle Constructor");
		}

		public Vehicle(string make, string model, int license)
		{
			Console.WriteLine("Vehicle Constructor");

			Make = make;
			Model = model;
			License = license;
		}

		/// <summary>
		/// Abstract method must be implemented in all derived classes.
		/// </summary>
		public abstract bool PayRegistration(float amount);

		/// <summary>
		/// The virtual keyword states that derived classes can override this method.
		/// </summary>
		public virtual void DisplayInfo()
		{
			Console.WriteLine($"Vehicle Information: {Make} {Model} | License: {License} | Registered: {IsRegistered}");
		} //ovrride it in base classes
	}

	public class Motocycle : Vehicle
	{
		public bool StreetLegal { get; set; }

		public Motocycle()
		{
			Console.WriteLine("Default Motocycle Constructor");
		}

		public Motocycle(string make, string model, int license, bool streetLegal) : base(make, model, license)
		{
			Console.WriteLine("Motocycle Constructor");
			StreetLegal = streetLegal;
		}

		/// <summary>
		/// Method overrides abstract method in base class. If not implemented in the derived class
		/// it will cause an error because the abstract method needs to be defined in concrete classes.
		/// </summary>
		public override bool PayRegistration(float amount)
		{
			return true;
		}

		/// <summary>
		/// The override declares that this method will be called instead of the virtual method
		/// in the parent class.
		/// </summary>
		public override void DisplayInfo()
		{
			Console.WriteLine($"Car Information: {Make} {Model} | Registered: {IsRegistered} | Street Legal: {StreetLegal}" );
		}
	}

	/// <summary>
	/// Sealed classes are used to restrict the inheritance feature of object oriented programming. 
	/// Once a class is defined as a sealed class, the class cannot be inherited.
	/// </summary>
	public sealed class Boat : Vehicle
	{
		public bool Outboard { get; set; }

		public Boat(string make, string model, int license, bool outboard = true) : base(make, model, license)
		{
			Console.WriteLine("Boat Constructor");
			Outboard = outboard;
		}

		/// <summary>
		/// Method overrides abstract method in base class. If not implemented in the derived class
		/// it will cause an error because the abstract method needs to be defined in concrete classes.
		/// </summary>
		public override bool PayRegistration(float amount)
		{
			return true;
		}

		/// <summary>
		/// The override declares that this method will be called instead of the virtual method
		/// in the parent class.
		/// </summary>
		public override void DisplayInfo()
		{
			Console.WriteLine($"Boat Information: {Make} {Model} | Registered: {IsRegistered} | Outboard: {Outboard}");
		}
	}

	/// <summary>
	/// Cannot derive from sealed class
	/// </summary>
	//public class SpeedBoat : Boat
	//{
	//}
	
	/// <summary>
	/// A type defined within a class or struct is called a nested type.
	/// Regardless of whether the outer type is a class or a struct, 
	/// nested types default to private; they are accessible only from their containing type.
	/// </summary>
	public class Course
	{
		private int credits = 1;

		public Course(int credits)
		{
			this.credits = credits;
			List<Student> students = new List<Student> { new Student(this), new Student(this), new Student(this) };
		}

		public class Student
		{
			private Course course;

			/// <summary>
			/// The nested, or inner, type can access the containing, or outer, type. 
			/// To access the containing type, pass it as an argument to the constructor of the nested type. 
			/// </summary>
			public Student(Course course)
			{
				this.course = course;
				Console.WriteLine($"Student created with credits {GetCredits()}.");
			}

			public Student()
			{
			}

			/// <summary>
			/// A nested type has access to all of the members that are accessible to its containing type. 
			/// It can access private and protected members of the containing type, including any inherited 
			/// protected members.
			/// </summary>
			public int GetCredits()
			{
				return course.credits;
			}
		}
	}
}


