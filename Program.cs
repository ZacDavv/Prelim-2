class Program
{
    static void Main(string[] args)
    {
        try
        {
            Vehicle bus = new ElectricBus("B001", "EcoBus", 80);
            Console.WriteLine($"Bus Range: {bus.CalculateRange()} km");

            Vehicle van = new GasPoweredVan("V001", "CargoVan", 50);
            Console.WriteLine($"Van Range: {van.CalculateRange()} km");

            // Trigger exception
            Vehicle lowBus = new ElectricBus("B002", "LowBus", 3);
            Console.WriteLine($"Low Bus Range: {lowBus.CalculateRange()} km");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Argument Error: {ex.Message}");
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine($"Operation Error: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Unexpected Error: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("System Shutdown");
        }
    }
}
