// See https://aka.ms/new-console-template for more information

int tal = 1;
do
{
    Console.WriteLine(tal);
    tal = tal + 1;
}
while (tal != 21);


Console.WriteLine("skriv ett tal mellan 1 och 100.");
int tal2 = int.Parse(Console.ReadLine());
do
{
    tal2 = tal2 + 1;
    Console.WriteLine(tal2);
}
while (tal2 != 101);