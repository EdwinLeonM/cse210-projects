using System;

public class Word
{
    private string _text;
    private List<bool> _hiddenLetters;

    public Word(string text)
    {
        _text = text;
        _hiddenLetters = new List<bool>();
        foreach (char letter in text)
        {
            if (Char.IsLetter(letter))
                _hiddenLetters.Add(false);
            else
                _hiddenLetters.Add(true);
        }
    }

    public void Hide()
    {
        for (int i = 0; i < _hiddenLetters.Count; i++)
        {
            if (!_hiddenLetters[i])
            {
                _hiddenLetters[i] = true;
                break;
            }
        }
    }

    public bool IsHidden()
    {
        return _hiddenLetters.All(letter => letter);
    }

    public string GetHiddenText()
    {
        string hiddenText = "";
        for (int i = 0; i < _text.Length; i++)
        {
            if (_hiddenLetters[i])
                hiddenText += "_";
            else
                hiddenText += _text[i];
        }
        return hiddenText;
    }
}