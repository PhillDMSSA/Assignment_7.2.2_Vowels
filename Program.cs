namespace Assignment_7._2._2_Vowels
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "Everyone";
            string input = "Super";
            Console.WriteLine(s);
            Console.WriteLine(ReverseVowel(s));
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(input);
            Console.WriteLine(ReverseVowel(input));

        }
        static bool GettingVowels(char c)
        {
            return (c == 'a' || c == 'A' || c == 'e' || c == 'E' || c == 'i' || c == 'I' ||
                    c == 'o' || c == 'O' || c == 'u' || c == 'U');
        }
        
        static string ReverseVowel(string s1)
        {
            int j = 0;

            char[] s = s1.ToCharArray();
            string vowel = "";
            
            for(int i =0;  i < s.Length; i++)
            {
                if(GettingVowels(s[i])) 
                {
                    j++;
                    vowel += s[i]; //adds current index if a vowel contains in GettingVowels to string vowel
                }
            }

            for(int i = 0;  i < s.Length; i++)
            {
                if (GettingVowels(s[i]))
                {
                    s[i] = vowel[--j];
                }
            }
            return String.Join("", s);
        }
    }
}
