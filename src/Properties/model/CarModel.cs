using System.ComponentModel.DataAnnotations;

namespace src.Properties.model;

public class CarModel
{
    [Key] 
    private Guid id { get; set; } = Guid.NewGuid();
    
    private string name { get; set; }
    
    private string brand { get; set; }
    
    private double price { get; set; }

}