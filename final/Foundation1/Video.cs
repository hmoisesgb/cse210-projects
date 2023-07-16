public class Video
{
    public string _title;
    public string _author;
    public int _lenght;

    public int _numberOfComments;

    public List<Comment> _comments = new List<Comment>();

    public void DisplayVideoInformation(){
        Console.WriteLine($"Title: {_title}\nAuthor: {_author}\nLenght: {_lenght} seconds\nNumber of Comments: {_comments.Count()}");
    }

    public void AddComment(Comment comment){
        _comments.Add(comment);
    }

    public void DisplayComments(){
        Console.WriteLine("Video Comments");
        foreach (Comment comment in _comments)
        {
            comment.DisplayComment();
        }
    }
}