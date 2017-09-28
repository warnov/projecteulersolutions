using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank
{
    class TriesContactOld
    {
        static void MainOld(String[] args)
        {
            LetterTree _directory = new LetterTree();
            List<string> _contacts2Find = new List<string>();

            int n = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < n; a0++)
            {
                string[] tokens_op = Console.ReadLine().Split(' ');
                string op = tokens_op[0];
                string contact = tokens_op[1];
                if (op == "add")
                {
                    _directory.AddContact(contact);
                }
                else
                {
                    _contacts2Find.Add(contact);
                }
            }

            foreach (var contact in _contacts2Find)
            {
                Console.WriteLine(_directory.Search(contact));
            }


            Console.ReadLine();
        }


        class LetterTree
        {
            public Dictionary<char, LetterTree> Children { get; set; }

            public LetterTree()
            {
                Children = new Dictionary<char, LetterTree>();
            }

            public void AddContact(string contact)
            {
                var initial = contact[0];
                if (!Children.ContainsKey(initial))
                {
                    Children.Add(initial, new LetterTree());
                }
                var child = Children[initial];
                if (contact.Length > 1)
                    child.AddContact(contact.Substring(1));
                else child.Children.Add('*', null);
            }

            public int Search(string contact)
            {
                var initial = contact[0];

                if (!Children.ContainsKey(initial))
                {
                    return 0;
                }
                var child = Children[initial];
                if (contact.Length == 1)
                {
                    return child.Contacts();
                }
                else return child.Search(contact.Substring(1));
            }

            public int Contacts()
            {
                var sum = 0;
                foreach (var child in Children.Values)
                {
                    if (child == null) sum += 1;
                    else sum += child.Contacts();
                }
                return sum;
            }
        }
       
    }
}
