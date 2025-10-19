using System;
using System.Collections.Generic;

namespace ValidParenthesesApp
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter a string of parentheses to validate:");
			string input = Console.ReadLine();

			bool result = IsValid(input);
			Console.WriteLine($"Is the input valid? {result}");
		}

		public static bool IsValid(string s)
		{
			Stack<char> myStack = new Stack<char>();

			foreach (char c in s)
			{
				if (c == '(' || c == '[' || c == '{')
				{
					myStack.Push(c);
				}
				else
				{
					if (myStack.Count == 0) return false;

					char top = myStack.Pop();
					if ((c == ')' && top != '(') ||
						(c == ']' && top != '[') ||
						(c == '}' && top != '{'))
					{
						return false;
					}
				}
			}

			return myStack.Count == 0;
		}
	}
}