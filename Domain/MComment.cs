namespace Domain;

public class MComment
{
    public Guid? Id { get; set; }
    
    public Guid ImageId { get; set; }
    
    public Guid UserId { get; set; }
    
    public string Message { get; set; }
}