class Test{
    public static void Main(string[]args){
      string text = "Hello!This is 123  Sakib.";
      int vowel = 0;
      int consonent = 0;
      int digit =0;
      foreach(char character in text.ToLower()){
        if(character=='a'||character=='i'||character=='e'||character=='o'||character=='u'){
          vowel++;
        }
        else if(character>='a'&&character<='z'){
          consonent++;
        }
        else if(char.IsDigit(character)){
          digit++;
        }
      }
      Console.WriteLine($"vowel:{vowel}\nconsonent:{consonent}\ndigit:{digit}");
    }   
    }

