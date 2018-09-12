using System;

public static class Bob
{
    public static string Response(string statement)
    {
        statement = statement.Trim();
        if(statement.Length == 0)
            return "Fine. Be that way!";
        else
        { 
            if (IsItAShout(statement))
                if (statement.EndsWith('?'))
                    return "Calm down, I know what I'm doing!";
                else
                    return "Whoa, chill out!";
            else
                if (statement.EndsWith('?'))
                    return "Sure.";
        }
        return "Whatever.";
    }

    public static bool IsItAShout(string toCheck)
    {
        if (toCheck.Length == 0)
            return false;
        if (!ContainsLetters(toCheck))
            return false;
        else
        {
            foreach (char value in toCheck)
                if (value > 96 && value < 123)
                    return false;
            return true;
        }
    }
    
    public static bool ContainsLetters(string toCheck)
    {
        if (toCheck.Length == 0)
            return false;
        else
        {
            foreach (char value in toCheck)
                if ((value > 96 && value < 123) || (value >=65 && value <=90))
                    return true;
            return false;
        }
    }

}