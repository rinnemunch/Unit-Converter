Console.Write("Enter temperature in Celsius: ");    
double celsius = Convert.ToDouble(Console.ReadLine());   

double fahrenheit = (celsius * 9 / 5) + 32;

Console.WriteLine(); 
Console.WriteLine("=== Conversion Result ===");
Console.WriteLine($"Celsius: {celsius:F2}°C");
Console.WriteLine($"Fahrenheit: {fahrenheit:F2}°F");