using System;

public static class Bob
{
    public static string Response(string statement)
    {
        statement = statement.Trim();
        if(statement.Length == 0)
            return "Fine. Be that way!";
        if (IsItAShout(statement))
            if (statement.EndsWith('?'))
                return "Calm down, I know what I'm doing!";
            else
                return "Whoa, chill out!";
        else
            if (statement.EndsWith('?'))
                return "Sure.";
        return "Whatever.";
    }

    public static bool IsItAShout(string toCheck)
    {
        if (toCheck.Length == 0)
            return false;
        if (!ContainsLetters(toCheck))
            return false;
        foreach (char value in toCheck)
            if (char.IsLower(value))
                return false;
        return true;
        
    }
    
    public static bool ContainsLetters(string toCheck)
    {
        if (toCheck.Length == 0)
            return false;
        foreach (char value in toCheck)
            if (char.IsLetter(value))
                return true;
        return false;
    }

}