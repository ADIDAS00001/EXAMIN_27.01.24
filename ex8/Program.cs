

using ex8;

var post=new Post();
post.Title="city";
post.Description="Duahanbe";
post.LikeCount=10;
post.IsPublished=false;
System.Console.WriteLine($"{post.Title} - {post.Description} - number of likes: {post.LikeCount}");