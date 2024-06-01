class Video
{
    public string _title { get; set; }
    public string _author { get; set; }
    public int _duration { get; set; }
    public List<Comment> _comments { get; set; }

    public Video(string title, string author, int duration)
    {
        _title = title;
        _author = author;
        _duration = duration;
        _comments = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int CommentCount()
    {
        return _comments.Count;
    }

    public override string ToString()
    {
        string result = $"Title: {_title}, Author: {_author}, Duration: {_duration} seconds, Comments: {CommentCount()}\n";
        foreach (var comment in _comments)
        {
            result += comment.ToString() + "\n";
        }
        return result;
    }
}