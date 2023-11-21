class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Length { get; set; }
    public List<Comment> Comments { get; set; } = new List<Comment>();

    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
    }

    public void AddComment(string commenter, string text)
    {
        Comments.Add(new Comment(commenter, text));
    }

    public int GetNumberOfComments()
    {
        return Comments.Count;
    }
}
