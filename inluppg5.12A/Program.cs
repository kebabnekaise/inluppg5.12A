using System;

namespace inluppg5_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int sidor = 5;
            int tarningar = 5;

            int[,]  nummer = new int[tarningar, 2];
            int checksumLocked = -1;

            Random rnd = new Random();

            while (checksumLocked < tarningar)
            {
                for (int i = 0; i < nummer.GetLength(0); i++)
                {
                    int num = rnd.Next(1, sidor+1);

                    if (nummer[i, 1] == 1)
                    {
                        continue;
                    }
                    else
                    {
                        nummer[i, 0] = num;
                    }
                }
                if(checksumLocked != 0)
                {
                    Console.WriteLine("Skriv vilka tärningar du vill ska låsas med mellanslag mellan varje index");
                    string[] lockIndeces = Console.ReadLine().Split(' ');

                    for (int j = 0; j < lockIndeces.Length; j++)
                    {
                        nummer[int.Parse(lockIndeces[j]) - 1, 1] = 1;
                        checksumLocked++;
                    }
                }
                

                //Skriver bara ut
                for(int k = 0; k < tarningar; k++)
                {
                    if (nummer[k, 1] == 1)
                    {
                        Console.WriteLine("Tärning " + (k+1) + " :" + nummer[k, 0] + "    (Låst)");                        
                    }
                    else
                    {
                        Console.WriteLine("Tärning " + (k + 1) + " :" + nummer[k, 0]);
                    }
                }
                if(checksumLocked == -1)
                {
                    checksumLocked++;
                }
            }
        }
    }
}

//Console.WriteLine("Tärning " + (i+1) + " :" + num + "    (Låst)");