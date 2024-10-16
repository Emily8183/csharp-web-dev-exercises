//Exercises: Control Flow & Collections

//TODO: Write your code for List Practice below:

using System.Numerics;

List<int> sample = new List<int>();

sample.Add(1);
sample.Add(2);
sample.Add(3);
sample.Add(4);
sample.Add(5);
sample.Add(6);
sample.Add(7);
sample.Add(8);
sample.Add(9);
sample.Add(10);
sample.Add(11);

//to call the CalSum function
int sum = CalSum(sample);
Console.WriteLine("the sum is " + sum);

Console.WriteLine("Choose a length: ");
string inputLength = Console.ReadLine();
int intLength = int.Parse(inputLength);



List<string> sample2 = new List<string>();

sample2.Add("abcde");
sample2.Add("abcd2");
sample2.Add("abd");

//to call the PrintLetters function
PrintLetters(sample2, intLength);

static int CalSum(List<int> sample)
{
    int sum = 0; 

    for (int i = 0; i < sample.Count; i++)
    {
        if (sample[i] % 2 == 0)
        {
            sum += sample[i];
        }
    }

    return sum;
}

static void PrintLetters(List<string> strings, int chosenLength)
{
    foreach (string s in strings)
    {
        if (s.Length == chosenLength)
        {
            Console.WriteLine(s);
        }
    }
}




