using System;
using System.Collections.Generic;

namespace ScriptureMemorizer
{
    public class Scripture
    {
        private Reference _reference;
        private List<Word> _words;

        public Scripture(Reference reference, string text)
        {
            _reference = reference;
            _words = new List<Word>();

            // Split passage into individual word tokens
            string[] rawWords = text.Split(' ');
            foreach (string wordText in rawWords)
            {
                _words.Add(new Word(wordText));
            }
        }

        public void HideRandomWords(int numberToHide)
        {
            Random random = new Random();

            // Collect indices of words that are not hidden yet (Exceeds Requirements)
            List<int> unhiddenIndices = new List<int>();
            for (int i = 0; i < _words.Count; i++)
            {
                if (!_words[i].IsHidden())
                {
                    unhiddenIndices.Add(i);
                }
            }

            // Hide up to 'numberToHide' unhidden words
            int wordsToHide = Math.Min(numberToHide, unhiddenIndices.Count);
            for (int i = 0; i < wordsToHide; i++)
            {
                int randomIndex = random.Next(unhiddenIndices.Count);
                int selectedWordIndex = unhiddenIndices[randomIndex];
                _words[selectedWordIndex].Hide();
                unhiddenIndices.RemoveAt(randomIndex);
            }
        }

        public string GetDisplayText()
        {
            List<string> displayWords = new List<string>();
            foreach (Word word in _words)
            {
                displayWords.Add(word.GetDisplayText());
            }

            return $"{_reference.GetDisplayText()} - {string.Join(" ", displayWords)}";
        }

        public bool IsCompletelyHidden()
        {
            foreach (Word word in _words)
            {
                if (!word.IsHidden())
                {
                    return false;
                }
            }
            return true;
        }
    }
}