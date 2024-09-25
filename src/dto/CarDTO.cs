namespace src.dto;

public class CarDTO
{
    private Guid id { get; set; } = Guid.NewGuid();
    private string type { get; set; }
    private string brand { get; set; }
    private double price { get; set; }
    
}