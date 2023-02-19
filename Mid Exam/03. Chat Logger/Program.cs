using System;
using System.Linq;
using System.Collections.Generic;

namespace _03_ChatLogger
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> chat = new List<string>();
            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] action = command.Split();
                if (action[0] == "Chat")
                {
                    string message = action[1];
                    chat.Add(message);
                }
                else if (action[0] == "Delete")
                {
                    string message = action[1];
                    if (chat.Contains(message))
                    {
                        chat.Remove(message);
                    }
                }
                else if (action[0] == "Edit")
                {
                    string message = action[1];
                    string editedVersion = action[2];
                    for (int i = 0; i < chat.Count; i++)
                    {
                        if (chat[i] == message)
                        {
                            chat[i] = editedVersion;
                        }
                    }
                }
                else if (action[0] == "Pin")
                {
                    string message = action[1];
                    if (chat.Contains(message))
                    {
                        chat.Remove(message);
                        chat.Add(message);
                    }
                }
                else if (action[0] == "Spam")
                {
                    for (int i = 1; i < action.Length; i++)
                    {
                        chat.Add(action[i]);
                    }
                }
            }
            foreach (string x in chat)
            {
                Console.WriteLine(x);
            }
        }
    }
}
