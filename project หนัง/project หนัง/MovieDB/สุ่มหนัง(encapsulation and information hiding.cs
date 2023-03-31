using System;
using System.Collections.Generic;
using System.Text;

namespace MovieDB
{
    public class RandomWordGenerator
    {
        private readonly string[] _words;
        private readonly Random _random;

        public RandomWordGenerator(string[] words)
        {
            _words = words;
            _random = new Random();
        }

        public string Generate()
        {
            int index = _random.Next(_words.Length);
            return _words[index];
        }
    }
}