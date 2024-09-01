// See https://aka.ms/new-console-template for more information
string first = "zheng";
string last = "zhu";

string first2 = first.Substring(1, first.Length - 1) + first.Substring(0, 1) + "ay";
string last2 = last.Substring(1, last.Length - 1) + last.Substring(0, 1) + "ay";

string result = first2.Substring(0, 1).ToUpper() + first2.Substring(1, first2.Length - 1) + " " + last2.Substring(0, 1).ToUpper() + last2.Substring(1, last2.Length - 1);

Console.WriteLine(result);