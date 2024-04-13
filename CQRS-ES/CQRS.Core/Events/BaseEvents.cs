public abstract class BaseEvents : Message
{
    protected BaseEvents(string type){
        this.Type = type;
    }
    public int Version { get; set; }
    public string Type { get; set; }
}