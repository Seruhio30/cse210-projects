class Video
{
    // Atributos
    public string Title { get; set; }
    public string Author { get; set; }
    public int Duration { get; set; }
    private List<Comment> comments = new List<Comment>(); // Almacenar comentarios

    public Video(string _title, string _author, int _duration)
    {
        _title = Title;
        _author = Author;
        _duration = Duration;
    }

    // Métodos
    public void AddComment(string name, string text)
    {
        Comment newComment = new Comment(name, text);
        comments.Add(newComment);
    }

    public int GetCommentCount()
    {
        return comments.Count;
    }

    public List<Comment> GetComments()
    {
        return comments;
    }
}