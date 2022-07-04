void PrintArray(string[] array)
{
   for(int i = 0;i < array.GetLength(0);i++ )
      Console.WriteLine(array[i] + " ,");
}
void FillArray(string[]array)
{
    for(int i = 0;i < array.GetLength(0);i++)
    {
        Console.WriteLine("enter the {i} element of the array");
        array[i] = Console.ReadLine();
    }
}
void CopyArray(string[] array,string[]arrayCopy )
{
    int index = 0;
    for(int i = 0;i < array.GetLength(0);i++)
        if(array[i].Length < 4 )
        {
            arrayCopy[index] = array[i];
            index++;
        }

}