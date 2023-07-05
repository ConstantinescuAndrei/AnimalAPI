namespace Domain;

public class MAnimal
{
    public Guid? Id { get; set; }
    public string Race { get; set; }
    public string Color { get; set; }
    public string ImageUrl { get; set; }
    public Guid UserId { get; set; }
}