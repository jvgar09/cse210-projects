// Abstraction for Video class
class Video
{
    // access modifier, data type, variable;
    private string _title;  // attributes
    private string _author;  // attributes
    private int _length;  // attributes
    private List<Comment> _comments;  // attributes


    // Construoctor
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    }

    public string GetTitle() // behavior/methods 
    {
        return _title;
    }

    public string GetAuthor() // behavior/methods 
    {
        return _author;
    }

    public int GetLength() // behavior/methods 
    {
        return _length;
    }
    
    public void AddComment(string commenterName, string commentText)
    {
        Comment comment = new Comment(commenterName, commentText);
        _comments.Add(comment);
    }

    public int GetNumberOfComments()  // behavior/methods 
    {
        return _comments.Count;
    }

    public List<Comment> GetComments()  // behavior/methods 
    {
        return _comments;
    }
}
