﻿using System;
using System.Collections.Generic;

<string, double>
<int, string>

Dictionary<string, int> myScoreBoard = new Dictionary<string, int>();

myScoreBoard.Add("firstInning", 10);
myScoreBoard.Add("secondInning", 20);
myScoreBoard.Add("thirdInning", 30);
myScoreBoard.Add("fourthInning", 40);
myScoreBoard.Add("fifthInning", 50);

namespace CatWorx.BadgeMaker
{
  class Program
  {
    static void Main(string[] args)
    {
     Console.WriteLine(2 * 3);         // Basic Arithmetic: +, -, /, *
Console.WriteLine(10 % 3);        // Modulus Op => remainder of 10/3
Console.WriteLine(1 + 2 * 3);     // order of operations
Console.WriteLine(10 / 3.0);      // int's and doubles
Console.WriteLine(10 / 3);        // int's 
Console.WriteLine("12" + "3");    // What happens here?

int num = 10;
num += 100;
Console.WriteLine(num);
num ++;
Console.WriteLine(num);
    }
  }
}