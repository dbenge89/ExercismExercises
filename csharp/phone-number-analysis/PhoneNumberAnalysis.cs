using System;

public static class PhoneNumber
{
    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {
        bool isNewYork = false;
        bool isFake = false;
        string[] formattedString = phoneNumber.Split('-');
        if (formattedString[0] == "212") isNewYork = true;
        if (formattedString[1] == "555") isFake = true;
        string local = formattedString[2];

        return (isNewYork, isFake, local);
    }

    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo)
    {
        return phoneNumberInfo.IsFake;
    }
}
