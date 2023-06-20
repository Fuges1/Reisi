namespace Reisi
{
    public class Flight
    {
        public string Destination { get; set; }
        public string Number { get; set; }
        public string Type { get; set; }

        public Flight(string destination, string number, string type)
        {
            Destination = destination;
            Number = number;
            Type = type;
        }
    }
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}