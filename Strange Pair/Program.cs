using System;


bool IsStrangePair(string str1, string str2)
{
    if (str1.Length == 0 && str2.Length == 0)
        return true;
    if (str1.StartsWith(str2[str2.Length-1].ToString()) && str1.EndsWith(str2[0].ToString()))
        return true;
    return false;
}

Console.WriteLine(IsStrangePair("sparkling", "groups"));
Console.WriteLine(IsStrangePair("bush", "hubris"));
Console.WriteLine(IsStrangePair("",""));

//Localde oluşturulan branchi ilk olarak remote göndermek