// Abstraction for Comment class
class Comment
{
    // access modifier, data type, variable;
    private string _commenterName; // attributes
    private string _commentText;  // attributes

     // Construoctor
    public Comment(string commenterName, string commentText)
    {
        _commenterName = commenterName;
        _commentText = commentText;
    }

    public string GetCommenterName() // behavior/methods 
    {
        return _commenterName;
    }

    public string GetCommentText() // behavior/methods
    {
        return _commentText;
    }
}
