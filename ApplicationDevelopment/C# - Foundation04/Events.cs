using System;
using System.Collections.Generic;
using System.Text;

namespace IntroCore
{
	class Events
	{
		public delegate void ExampleEvent();
		public static event ExampleEvent exampleEvent;

		public static void Display()
		{
			// (1) - events
			// Events enable a class or object to notify other classes or objects 
			// when something of interest occurs. 
			// The class that sends (or raises) the event is called the publisher and 
			// the classes that receive (or handle) the event are called subscribers.
			exampleEvent += Method01;
			exampleEvent += Method02;
			exampleEvent += Method03;

			exampleEvent.Invoke();


			// In a typical C# Windows Forms or Web application, 
			// you subscribe to events raised by controls such as buttons and list boxes.
			Button button = new Button();
			ButtonReceiver buttonReceiver = new ButtonReceiver();

			buttonReceiver.Subscribe(button);
			button.Pressed();
		}

		public static void Method01()
		{
			Console.WriteLine("method 01");
		}

		public static void Method02()
		{
			Console.WriteLine("method 02");
		}

		public static void Method03()
		{
			Console.WriteLine("method 03");
		}

		public class ButtonReceiver
		{
			public void Subscribe(Button button)
			{
				button.pressEvent += ReceiveEvent;
			}

			public void ReceiveEvent()
			{
				Console.WriteLine("Received Event");
			}
		}

		public class Button
		{
			public delegate void PressEvent();
			public event PressEvent pressEvent;

			public void Pressed()
			{
				Console.WriteLine("Button Pressed");
				pressEvent();
			}
		}
	}
}
