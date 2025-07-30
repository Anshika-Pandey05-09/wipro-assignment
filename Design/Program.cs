// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using Design.Factory;
using Design.Observer;
using Design.Utilities;

//Console.WriteLine("Singleton Logger Example");

//// Get the singleton instance
//Logger logger1 = Logger.Instance;
//Logger logger2 = Logger.Instance;

//// Log some messages
//logger1.Log("Starting the application.");
//logger2.Log("Application is running...");

//// Verify it's the same instance
//Console.WriteLine($"Logger 1 and Logger 2 are same instance: {object.ReferenceEquals(logger1, logger2)}");


// // Factory Pattern Example

//Console.WriteLine("\nFactory Pattern Example:");

//IDocument doc1 = DocumentFactory.CreateDocument("pdf");
//doc1.Generate();

//IDocument doc2 = DocumentFactory.CreateDocument("word");
//doc2.Generate();

// Observer pattern Example

Console.WriteLine("\nObserver Pattern Example:");

WeatherStation station = new WeatherStation();

WeatherDisplay display1 = new WeatherDisplay("Display 1");
WeatherDisplay display2 = new WeatherDisplay("Display 2");

station.RegisterObserver(display1);
station.RegisterObserver(display2);

station.SetWeatherData(30.5f, 65f);

station.RemoveObserver(display1);

station.SetWeatherData(32f, 70f);