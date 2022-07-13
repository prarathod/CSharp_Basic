
Console.WriteLine("******** Program To Create Array on User Side *********");

Console.Write("Enter The legth Of Array:- ");
int num = int.Parse(Console.ReadLine());
int[] numArray = new int[num];

for (int i = 0; i < num; i++)
{
    Console.Write("Enter Value on Index "+(i+1)+" :- ");
    numArray[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("***** Your array is ********");
foreach(int elm in numArray)
{
    Console.Write(elm +" ");
}