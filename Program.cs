using System;

namespace TrueOrFalse
{
  class Program
  {
		static void Main(string[] args)
    {
      // Do not edit these lines
      Console.WriteLine("Welcome to 'True or False?'\nPress Enter to begin:");
      string entry = Console.ReadLine();
      Tools.SetUpInputStream(entry);

      // Type your code below
      string[] questions = new string[]
      {
        "Is WoW fire?",
        "Is FFXIV fire?",
        "Is Crowfall fire?",
        "Is Ashes of Creation fire?",
        "Is Camelot Unchained fire?"
      };

      bool[] answers = new bool[]
      {
        true,
        true,
        false,
        false,
        true
      };

      bool[] responses = new bool[questions.Length];

      if (questions.Length != answers.Length)
      {
        Console.WriteLine("Warning! The number of questions does not match the number of answers.");
      }

      int askingIndex = 0;
      foreach (string question in questions)
      {
        string input;
        bool isBool;
        bool inputBool;

        Console.WriteLine(question);
        Console.WriteLine("True or false?");
        input = Console.ReadLine();
        isBool = Boolean.TryParse(input, out inputBool);

        while (!isBool)
        {
          Console.WriteLine("Please respond with 'true' or 'false'.");
          input = Console.ReadLine();
          isBool = Boolean.TryParse(input, out inputBool);
        }
        responses[askingIndex] = inputBool;
        askingIndex++;
      }

      int scoringIndex = 0;
      int score = 0;

      foreach (bool answer in answers)
      {
        bool response = responses[scoringIndex];
        Console.Write(scoringIndex + 1 + ".");
        Console.WriteLine($"Input: {response} | Answer: {answer}");
        if (response == answer)
        {
          score++;
        }
        scoringIndex++;
      }
      Console.WriteLine($"You got {score} out of {questions.Length} correct!");
    }
  }
}
