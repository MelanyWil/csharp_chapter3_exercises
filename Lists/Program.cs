// See https://aka.ms/new-console-template for more information
using System.Numerics;

Console.WriteLine("Hello, Lists!");

static int EvenSum(List<int> arr) {
    int sum = 0;
    foreach(int integer in arr) {
        if(integer % 2 == 0) {
           sum += integer; 
        }
    }
    return sum;
}

List<int> numbers = [1, 1, 2, 3, 5, 6, 7, 8, 9, 9];

Console.WriteLine(EvenSum(numbers));


// static List<string> FiveLetterWords (List<string> words) {
//     return words.FindAll(word => word.Length == 5);
//}

List<string> animals = ["Bear", "Tiger", "Mouse", "Zebra", "Panda", "Dog", "Cat", "Turtle"];

// List<string> results = FiveLetterWords(animals);
// foreach (string animal in results) {
//     Console.WriteLine(animal);
// }

static void FiveLetterWords (List<string> words) {
    Console.WriteLine("Enter a number: ");
    int input = int.Parse(Console.ReadLine());

    foreach(string word in words) 
    {
        if(word.Length == input) 
        {
            Console.WriteLine(word);
        }
    }
}

FiveLetterWords(animals);
