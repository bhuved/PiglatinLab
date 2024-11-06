// See https://aka.ms/new-console-template for more information
using System.Text.RegularExpressions;
Console.WriteLine("***Pig Latin Lab***");
//pig latin lab
do
{
    Console.WriteLine("Enter Some text");
    string str = Console.ReadLine().ToLower();
    Console.WriteLine(str);
    int vowelPosition = -1;
    string[] words = str.Split(' ');
    string pigLatinWord = "";
    Regex regex = new Regex("[0-9@_!#$%^&*()<>?/|/}{~:]");
    


    foreach (string word in words)
    {
        string checkWord = "";
       
        if (regex.IsMatch(word))
        {
            checkWord = word;
            pigLatinWord = pigLatinWord + " " + checkWord;
            continue;
        }
        for (int i = 0; i < word.Length; i++)
        {

            if (word[i] == 'a' || word[i] == 'e' || word[i] == 'i' || word[i] == 'o' || word[i] == 'u')
            {
                vowelPosition = i;
                break;
            }
            vowelPosition = i;
        }

        if (word.EndsWith("."))
        {
            string wordDot = word.Substring(0, word.Length - 1);

            if (vowelPosition == -1 || vowelPosition == 0)
            {
                checkWord = wordDot + "way.";
            }
            else
            {
                checkWord = wordDot.Substring(vowelPosition) + wordDot.Substring(0, vowelPosition) + "ay.";
            }
        }
        else
        {
            if (vowelPosition == -1 || vowelPosition == 0)
            {
                checkWord = word + "way";
            }
            else
            {
                checkWord = word.Substring(vowelPosition) + word.Substring(0, vowelPosition) + "ay";
            }
        }
         
        //Console.WriteLine(checkWord);
        pigLatinWord = pigLatinWord + " " + checkWord;
    }
    Console.WriteLine(pigLatinWord);

} while (GetPlayAgainAnswer() == true);

bool GetPlayAgainAnswer(string strMessage = "Would you like to Continue? y/n")
{
    Console.WriteLine(strMessage);
    string userAnswer = Console.ReadLine();
    if (userAnswer.ToLower() != "y")
    {
        return false;
    }

    //Console.WriteLine("YEAH LETS PLAY");
    return true;
}

