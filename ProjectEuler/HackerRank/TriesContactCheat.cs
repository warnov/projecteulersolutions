using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank
{
    class TriesContact
    {
        static Dictionary<string, int> _directory = new Dictionary<string, int>();
        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < n; a0++)
            {
                string[] tokens_op = Console.ReadLine().Split(' ');
                string op = tokens_op[0];
                string contact = tokens_op[1];
                if (op == "add")
                {
                    AddContact(contact);
                }
                else
                {
                    var ocurrences = _directory.ContainsKey(contact) ? _directory[contact] : 0;
                    Console.WriteLine(ocurrences);
                }
            }

            Console.ReadLine();
        }

        private static void AddContact(string contact)
        {
            var length = contact.Length;
            for (int i = 0; i < contact.Length; i++)
            {
                var subWord = contact.Substring(0, i + 1);
                if (_directory.ContainsKey(subWord))
                {
                    _directory[subWord]++;
                }
                else _directory.Add(subWord, 1);
            }
        }       
    }
}
