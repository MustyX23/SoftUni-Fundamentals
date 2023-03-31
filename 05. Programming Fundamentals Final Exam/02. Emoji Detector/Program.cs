using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02.EmojiDetector
{
    internal class EmojiDetector
    {
        static void Main(string[] args)
        {
            string emojiPattern = @"([:|*]{2})(?<emoji>[A-Z][a-z]{2,})\1";
            Regex emojiRegex = new Regex(emojiPattern);
            Regex numberRegex = new Regex(@"\d");

            string text = Console.ReadLine();

            MatchCollection coolFactorNums = numberRegex.Matches(text);
            MatchCollection emojies = emojiRegex.Matches(text);

            long coolFactor = 1;

            foreach (Match item in coolFactorNums)
            {
                coolFactor *= int.Parse(item.Value.ToString());
            }

            List<string> emojis = new List<string>();

            foreach (Match emoji in emojies)
            {
                string emojiName = emoji.Groups["emoji"].Value.ToString();

                long currEmojiCoolnes = 0;

                for (int i = 0; i < emojiName.Length; i++)
                {
                    currEmojiCoolnes += (long)emojiName[i];
                }

                if (currEmojiCoolnes >= coolFactor)
                {
                    emojis.Add(emoji.Value.ToString());
                }
            }

            Console.WriteLine($"Cool threshold: {coolFactor}");
            Console.WriteLine($"{emojies.Count} emojis found in the text. The cool ones are:");

            foreach (var emoji in emojis)
            {
                Console.WriteLine(emoji);
            }
        }
    }
}