// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Arrays!");
int[] numbers = {1, 1, 2, 3, 5, 8};
foreach(int number in numbers) {
    if(number % 2 != 0) {
        Console.WriteLine(number);
    }
    
}