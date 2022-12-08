namespace noisysiteapp.sitedata;
public class Embed{

    public string Id{get; set;}
    public string? Subject {get; set;}
    public string? Link {get; set;}

    public string Content {get; set;}

    public DateTime CreatedDate {get; set;}

    public DateTime? LastScraped   { get; set;}
}