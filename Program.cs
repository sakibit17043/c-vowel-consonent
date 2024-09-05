class Test{
    public static void Main(string[]args){
      string input = "Hello!This is 123 Sakib!";
      int vowelCount = input.Count(c=>"aeiouAEIOU".Contains(c));
      int consonentCount = input.Count(c=>char.IsLetter(c) && !"aeiouAEIOU".Contains(c));
      int digitCount = input.Count(c=>char.IsDigit(c));
      int specialCharacterCount = input.Count(c=>!char.IsLetterOrDigit(c) && !char.IsWhiteSpace(c));
      int whiteSpaceCount = input.Count(c=>char.IsWhiteSpace(c));
      string[] word = input.Split(new char[]{' ','!'},StringSplitOptions.RemoveEmptyEntries);
      int wordCount = input.Split(new char[]{' ','!'},StringSplitOptions.RemoveEmptyEntries).Length;
      Console.WriteLine($"Number of vowels:{vowelCount}");
      Console.WriteLine($"Number of consonent:{consonentCount}");
      Console.WriteLine($"Number of digit:{digitCount}");
      Console.WriteLine($"Number of special character:{specialCharacterCount}");
      Console.WriteLine($"Number of white space:{whiteSpaceCount}");
      Console.WriteLine($"Number of words:{wordCount}");
      foreach(string i in word){
        Console.WriteLine(i);
      }
     
    }   
    }

