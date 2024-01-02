namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String str = "The quick brown fox jumps over the lazy dog";
            //a)   	Print the character at the 12th index.
            Console.WriteLine(str[12]);
            Console.WriteLine("---------------------------");

            //b)	Check whether the String contains the word “is”.
            if (str.Contains("is"))
            {
                Console.WriteLine("Found");
            }
            else
            {
                Console.WriteLine("Not found");
            }
            Console.WriteLine("---------------------------");

            //c)	Add the string “and killed it” to the existing string.
            string str1 = "and killed it";
            Console.WriteLine(str + " " + str1);
            Console.WriteLine("---------------------------");

            //d)	Check whether the String ends with the word “dogs”.

            int dind = str.LastIndexOf("d");

            if (dind != -1)
            {
                string last = str.Substring(dind);
                if (last == "dog")
                {
                    Console.WriteLine("Dog is found");
                }
                else
                {
                    Console.WriteLine("Dog is not found");
                }

            }
            else
            {
                Console.WriteLine("Dog is not found");
            }

            Console.WriteLine("---------------------------");


            //e)	Check whether the String is equal to “The quick brown Fox jumps over the lazy Dog”.
            string str2 = "The quick brown Fox jumps over the lazy Dog";
            if (str.Equals(str2))
            {
                Console.WriteLine("String is equal");
            }
            else
            {
                Console.WriteLine("String is not equal");
            }
            Console.WriteLine("---------------------------");

            //f)Check whether the String is equal to “THE QUICK BROWN FOX JUMPS OVER THE LAZY DOG”.    
            string str3 = "THE QUICK BROWN FOX JUMPS OVER THE LAZY DOG";
            if (str.Equals(str3, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("String is Equal");
            }
            else
            {
                Console.WriteLine("String is not Equal");
            }
            Console.WriteLine("---------------------------");

            //g)	Find the length of the String.
            Console.WriteLine(str.Length);
            Console.WriteLine("---------------------------");

            //h)  	Check whether the String matches to “The quick brown Fox jumps over the lazy Dog”.
            string str4 = "The quick brown Fox jumps over the lazy Dog";
            if (str.Equals(str4))
            {
                Console.WriteLine("String is Equal");
            }
            else
            {
                Console.WriteLine("String is not Equal");
            }
            Console.WriteLine("---------------------------");

            //i)        Replace the word “The” with the word “A”.
            Console.WriteLine(str.Replace("The", "A"));
            Console.WriteLine("---------------------------");


            //j)        Split the above string into two such that two animal names do not come together.
            string[] splt = str.Split(' ');

            for (int i = 0; i < splt.Length; i++)
            {
                if (splt[i] == "fox")
                {
                    for (int j = 0; j <= i; j++)
                    {
                        Console.Write(splt[j] + " ");

                    }
                }

            }
            Console.WriteLine();
            for (int i = 0; i < splt.Length; i++)
            {
                if (splt[i] == "fox")
                {
                    for (int j = i + 1; j < splt.Length; j++)
                    {
                        Console.Write(splt[j] + " ");

                    }
                }

            }
            Console.WriteLine();

            Console.WriteLine("---------------------------");
            //k)   	Print the animal names alone separately from the above string.
            string[] animal = { "fox", "dog" };
            foreach (string s in splt)
            {
                foreach (string anm in animal)
                {
                    if (anm == s)
                    {
                        Console.WriteLine(anm);
                    }
                }
            }
            Console.WriteLine("---------------------------");

            //l)        Print the above string in completely lower case.
            Console.WriteLine(str.ToLower());
            Console.WriteLine("---------------------------");

            //m)	Print the above string in completely upper case.
            Console.WriteLine(str.ToUpper());
            Console.WriteLine("---------------------------");

            //n)  	Find the index position of the character “a”.
            Console.WriteLine(str.IndexOf("a"));
            Console.WriteLine("---------------------------");

            //o)  	Find the last index position of the character “e”.
            Console.WriteLine(str.LastIndexOf("e"));
            Console.WriteLine("---------------------------");

            //p)  	Prompt the user to enter the home directory of Tomcat server. To the path that user enters, add another path to  WebApps/MyApps/Images  directory and display it in the console. Use verbatim string literals.
            Console.WriteLine("Enter the path:");
            string path = Console.ReadLine();
            Console.WriteLine(path + @"/WebApps/MyApps/Images");
            Console.WriteLine("---------------------------");

            /*q)    Write a C# code that has a constant string that represents poem lines
                    I WANDER'D lonely as a cloud
                    That floats on high o'er vales and hills, */
            const string Poem = "I WANDER'D lonely as a cloud\nThat floats on high o'er vales and hills";
            Console.WriteLine(Poem);

        }
    }
}
