using System;

public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int? _endVerse;

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = null;
    }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
    }

    public string Book
    {
        get { return _book; }
        set { _book = value; }
    }

    public int Chapter
    {
        get { return _chapter; }
        set { _chapter = value; }
    }

    public int Verse
    {
        get { return _verse; }
        set { _verse = value; }
    }

    public int? EndVerse
    {
        get { return _endVerse; }
        set { _endVerse = value; }
    }

    public string GetDisplayText()
    {
        if (_endVerse == null)
            return $"{_book} {_chapter}:{_verse}";
        else
            return $"{_book} {_chapter}:{_verse}-{_endVerse}";
    }
}