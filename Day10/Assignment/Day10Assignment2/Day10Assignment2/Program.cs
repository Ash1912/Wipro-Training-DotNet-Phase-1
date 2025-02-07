// See https://aka.ms/new-console-template for more information
using Day10Assignment2.Factory;
using Day10Assignment2.Observer;
using Day10Assignment2.Singleton;

class Program
{
    static void Main()
    {
        //Singleton
        Logger logger1 = Logger.GetInstance();
        Logger logger2 = Logger.GetInstance();

        logger1.Log("Singleton Pattern Demonstrated");

        Console.WriteLine($"Are logger1 and logger2 the same instance? {logger1 == logger2}");

        //Factory
        Document pdf = DocumentFactory.CreateDocument("pdf");
        pdf.Open();

        Document word = DocumentFactory.CreateDocument("word");
        word.Open();

        //Observer
        WeatherStation weatherStation = new WeatherStation();

        WeatherDisplay display1 = new WeatherDisplay("Main");
        WeatherDisplay display2 = new WeatherDisplay("Mobile");

        weatherStation.RegisterObserver(display1);
        weatherStation.RegisterObserver(display2);

        weatherStation.SetTemperature(25.0f);
        weatherStation.SetTemperature(30.0f);
    }
}