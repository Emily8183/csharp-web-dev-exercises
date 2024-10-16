//Exercises: Control Flow & Collections

//TODO: Write your code for List Practice below:

using System.Numerics;

//exercise 1: calculate the sum of the List sample
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

//exercise 2: print out the string matching the required length

Console.WriteLine("Choose a length: ");
string inputLength = Console.ReadLine();
int intLength = int.Parse(inputLength);

string stringSample = "I would not, could not, in a box. I would not, could not with a fox.I will not eat them in a house. I will not eat them with a mouse.";

List<string> sample2 = stringSample.Split(',').ToList();

//List<string> sample2 = new List<string>();

//sample2.Add("abcde");
//sample2.Add("abcd2");
//sample2.Add("abd");

PrintLetters(sample2, intLength);

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




