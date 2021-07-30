using System;
using System.Collections.Generic;

namespace ClearMeasure
{
  public class FizzBuzz
  {

    public List<string> Program(int upperBound)
    {
      List<string> fizzBuzz = new List<string>();

      for (int i = 1; i <= upperBound; i++)
      {
        if (i % 5 == 0 & i % 3 == 0)
        {
          fizzBuzz.Add("FizzBuzz");
        } 
        else if (i % 5 == 0)
        {
          fizzBuzz.Add("Buzz");
        }
        else if (i % 3 == 0)
        {
          fizzBuzz.Add("Fizz");
        }
        else{
          fizzBuzz.Add(i.ToString());
        }
      }

      return fizzBuzz;
    }
  }
}