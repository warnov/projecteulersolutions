/*
A kidnapper wrote a ransom note but is worried it will be traced back to him. He found a magazine and wants to know if he can cut out whole words from it and use them to create an untraceable replica of his ransom note. The words in his note are case-sensitive and he must use whole words available in the magazine, meaning he cannot use substrings or concatenation to create the words he needs.

Given the words in the magazine and the words in the ransom note, print Yes if he can replicate his ransom note exactly using whole words from the magazine; otherwise, print No.

Input Format

The first line contains two space-separated integers describing the respective values of  (the number of words in the magazine) and  (the number of words in the ransom note). 
The second line contains  space-separated strings denoting the words present in the magazine. 
The third line contains  space-separated strings denoting the words present in the ransom note.

Constraints

.
Each word consists of English alphabetic letters (i.e.,  to  and  to ).
The words in the note and magazine are case-sensitive.
Output Format

Print Yes if he can use the magazine to create an untraceable replica of his ransom note; otherwise, print No.

Sample Input 0

6 4
give me one grand today night
give one grand today
Sample Output 0

Yes
Sample Input 1

6 5
two times three is not four
two times two is four
Sample Output 1

No*/



using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static void Main3(String[] args)
    {
        string[] tokens_m = Console.ReadLine().Split(' ');
        int m = Convert.ToInt32(tokens_m[0]);
        int n = Convert.ToInt32(tokens_m[1]);
        string[] magazine = Console.ReadLine().Split(' ');
        string[] ransom = Console.ReadLine().Split(' ');



        var magazineCheck = new Dictionary<string, int>();
        foreach (var magazineWord in magazine)
        {
            if (magazineCheck.ContainsKey(magazineWord))
            {
                magazineCheck[magazineWord]++;
            }
            else
            {
                magazineCheck.Add(magazineWord, 1);
            }
        }
        var complete = true;
        foreach (var ransomWord in ransom)
        {
            if (!magazineCheck.ContainsKey(ransomWord))
            {
                complete = false;
                break;
            }
            else
            {
                if (magazineCheck[ransomWord] == 0)
                {
                    complete = false;
                    break;
                }
                else magazineCheck[ransomWord]--;
            }
        }
        var answer = complete ? "Yes" : "No";
        Console.Write(answer);



        Console.ReadLine();
    }
}


/*Conclusions
 * 
 * I tried for simplicity at first using lists, and they worked fine with small inputs; 
 * but when the number of elements grew up to thousands, the list.contains got very slow
 * It was better then using hash tables as they doesn't have to make a scan, but they are
 * organized with an index based on the has table. 
 * Then I noticed that obviously hash table can't have repeated indexes, so I defined the amount
 * of words available for each occurence (increased by one on each aparison) 
 * and that was the value for the table. And each time 
 * a word appeared in the ransom note, the value of the hash table was decreased
 * Actually I used dictionary to make the table generic for string, int and be able to operate
 * easily with the integer (for increments and drecrements)*/