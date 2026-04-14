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
			// Use a stack to keep track of opening brackets while scanning the string.
			Stack<char> myStack = new Stack<char>();

			foreach (char c in s)
			{
				// If the character is an opening bracket, push it onto the stack.
				if (c == '(' || c == '[' || c == '{')
				{
					myStack.Push(c);
				}
				else
				{
					// If the current character is a closing bracket but the stack is empty,
					// there is no matching opening bracket.
					if (myStack.Count == 0) return false;

					// Pop the most recent opening bracket and compare it with the closing one.
					char top = myStack.Pop();
					if ((c == ')' && top != '(') ||
						(c == ']' && top != '[') ||
						(c == '}' && top != '{'))
					{
						// The closing bracket does not match the opening bracket.
						return false;
					}
				}
			}

			// The string is valid only if there are no unmatched opening brackets left.
			return myStack.Count == 0;
		}
	}
}