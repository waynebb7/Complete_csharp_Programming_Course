﻿using System.Diagnostics;
using System.Text.RegularExpressions;



namespace _13._175.Regex___
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\d";
            Regex regex = new Regex(pattern);
            Debug.WriteLine("Does 2 match pattern: " + regex.IsMatch("2"));
            Debug.WriteLine("Does a match pattern: " + regex.IsMatch("a"));


            string pattern2 = "(the)";
            Regex regex2 = new Regex(pattern2);
            string text = "the quick brown fox jumps over the lazy dog";
            Match match = regex2.Match(text);
            MatchCollection matches = regex.Matches(text);

        }
    }
}