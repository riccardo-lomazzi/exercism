using System;

public static class Leap
{
    public static bool IsLeapYear(int year)
    {
        bool result = false;
        //throw new NotImplementedException("You need to implement this function.");
        if (year<0)
            return false;
        if (year % 4 == 0)
        {
            result = true;
            if (year % 100 == 0)
            {
                result = false;
                if (year % 400 == 0)
                    result = true;
            }
        }
        return result;
    }
}