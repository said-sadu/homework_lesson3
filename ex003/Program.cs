Console.Write("Введите число: ");
int cube = Convert.ToInt32(Console.ReadLine());

void Cube(int[] cube)
{
    int pos = 0;
    int length = cube.Length;
    while (pos < length)
    {
        cube[pos] = Convert.ToInt32(Math.Pow(pos, 3));
        pos++;
    }
}

void PrintArry(int[] coll)
{
    int count = coll.Length;
    int index = 0;
    while (index < count)
    {
        Console.Write(coll[index] + " ");
        index++;
    }
}

int[] arry = new int[cube + 1];
Cube(arry);
PrintArry(arry);