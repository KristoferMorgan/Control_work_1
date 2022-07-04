void PrintArray(string[] array)
{
   for(int i = 0;i < array.GetLength(0)-1;i++ )
     {
         {
           Console.Write(array[i]+" , " );
         }
     }
     Console.Write(array[array.GetLength(0)-1]);
}
void FillArray(string[]array)
{
    for(int i = 0;i < array.GetLength(0);i++)
    {
        Console.WriteLine($"enter the {i+1} element of the array");
        array[i] = Console.ReadLine()??"";
    }
}
void CopyNumber3_2_1Array(string[] array,string[]arrayCopy)
{   
    int index = 0;
    for(int i = 0;i < array.GetLength(0);i++)
        if(array[i].Length < 4 )
        {
            arrayCopy[index] = array[i];
            index++;
        }
}      
Console.Write("enter the number of array elements: ");
int index = 0;
int rows = int.Parse(Console.ReadLine()?? "");
string[]inputArray = new string[rows];
string[]outputArray = new string[rows];
FillArray(inputArray);
Console.WriteLine("output the entered array:");
PrintArray(inputArray);
foreach (string Element in inputArray) 
    if (Element.Length < 4)
        index++;
CopyNumber3_2_1Array(inputArray,outputArray);
Array.Resize(ref outputArray,index);
Console.WriteLine();
Console.WriteLine("print the resulting array:");
PrintArray(outputArray);
 

