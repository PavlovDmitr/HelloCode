int[] array = {11, 21, 31, 41, 15, 61, 23, 29, 55};
int find = int.Parse(Console.ReadLine());
int n = array.Length;
int index = 0;
while (index<n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}