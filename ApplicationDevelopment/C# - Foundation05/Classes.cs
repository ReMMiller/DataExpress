using System;
using System.Collections.Generic;
using System.Text;

namespace IntroCore
{
	class Classes
	{
		public static void Display()
		{
			// (1) - Classes
			// A class is a way to define an object that contains data and
			// methods. It encapsulates related methods and members into one
			// object. From the class, which can be thought of as a blueprint, an
			// instance of the class can be created. This instance is a reference type
			// which mean that memory is allocated for it and it resides on the heap.
			Student student1 = new Student();
			Student student2 = new Student("Cristian", 19, 4.0f);
			Student student3 = new Student(student2);
			Student student4 = student3;
			student3.Age = 20;

			Console.WriteLine("{0}", student1.ToString());
			Console.WriteLine("{0}", student2.ToString());
			Console.WriteLine("{0}", student3.ToString());
			Console.WriteLine("{0}", student4.ToString());
			Console.WriteLine($"The number of students: {Student.GetNumStudents()}");

			for (int i = 0; i < student4.NumInstructors; i++)
			{
				Console.WriteLine("{0}", student4[i]);
			}
		}
	}

	/// <summary>
	/// Helper class for math functions and constants.
	/// </summary>
	static class Math
	{
		const float PI = 3.1415f;
		const float TwoPI = PI * 2.0f;

		static float DegToRad(float degrees) { return degrees * (PI / 180.0f); }
		static float RadToDeg(float radians) { return radians * (180.0f / PI); }
	}

	#region Student Class
	/// <summary>
	/// Student contain the information for the student.
	/// </summary>
	class Student
	{
		// Fields can be thought of as members or variables of the class.
		// They contain the data of the class.
		private int age = 4;
		private float gpa;
		private int cohort;
		private string[] instructors = new string[] { "Beatty", "Rich", "Cox" };
		// Properties are like methods to access the data in the class.
		// Properties enable a class to expose a public way of getting and setting values,
		// while hiding implementation or verification code.    
		public int Age
		{
			get { return age; }
			set
			{
				// The value keyword is used to define the value being assigned by the set accessor.
				if (value > 0 && value < 100) age = value;
			}
		}

		public float GPA
		{
			get { return gpa; }
			private set
			{
				if (value >= 0.0f && value <= 4.0f) gpa = value;
			}
		}

		public int Cohort
		{
			get { return cohort; }
			// Omitting the set accessor makes the property read-only
		}

		public string this[int i]
		{
			get { return instructors[i]; }
			set { instructors[i] = value; }
		}

		// An indexer allows an object to be indexed such as an array.
		public int NumInstructors
		{
			get { return instructors.Length; }
		}

		// An Auto-Property is a concise way to create a field/property.
		// The compiler creates an private, anonymous field that can be accessed only
		// through the property.
		public string Name { get; set; }
		// In C# 6 and later you can initialize auto properties like a field
		public int ID { get; set; } = 0;

		static private int numStudents = 0;

		// Constructors are called when an instance of the class is created.
		// Constructors have the same name as the class or struct, 
		// and they usually initialize the data members of the new object.
		// Student student1 = new Student();
		// Student student2 = new Student("Cristian", 19, 4.0f);

		// Default Constructor doesn't take any parameters
		public Student()
		{
			numStudents++;
		}

		public Student(string name, int age, float gpa)
		{
			Name = name;
			this.age = age;
			this.gpa = gpa;
			cohort = 33;
			numStudents++;
		}
	
		// A static constructor is used to initialize any static data, 
		// or to perform a particular action that needs to be performed once only. 
		// It is called automatically before the first instance is created or 
		// any static members are referenced.
		static Student()
		{
			numStudents = 0;
		}

		// Copy Constructor
		public Student(Student otherStudent)
		{
			Name = otherStudent.Name;
			age = otherStudent.age;
			gpa = otherStudent.gpa;
			cohort = otherStudent.cohort;

			numStudents++;
		}

		public override string ToString()
		{
			return $"Name: {Name} - Age: {age} - GPA: {gpa}";
		}

		public static int GetNumStudents()
		{
			return numStudents;
		}
	}
	#endregion

	// access modifiers
	// public
	//  The type or member can be accessed by any other code in the same assembly or another assembly that references it.
	// private
	//  The type or member can be accessed only by code in the same class or struct.
	// protected
	//  The type or member can be accessed only by code in the same class, or in a class that is derived from that class.
	// internal
	//	The type or member can be accessed by any code in the same assembly, but not from another assembly.
	// protected internal 
	//   The type or member can be accessed by any code in the assembly in which it is declared, or from within a derived class in another assembly.
	// private protected 
	//   The type or member can be accessed only within its declaring assembly, by code in the same class or in a type that is derived from that class.
}
