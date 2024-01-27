namespace ex8;

public class Post
{
    public string Title { get; set; }
    public string Description { get; set; }
    public int LikeCount { get; set; }
    // public List<comments> comments =new List<Comments>();
    public bool IsPublished { get; set; }
    public string Publish()
    {
        return "The post is published.";
        IsPublished=true;
    }
    public void Like()
    {
        LikeCount++;
    }
    // public string Comment(string message)
    // {
        
    // }


}
