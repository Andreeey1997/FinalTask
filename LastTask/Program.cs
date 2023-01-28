string[] array1 = new string[5] {"123", "23", "hello", "world", "res"};
string[] array2 = new string[array1.Length];

void ThreeSymbolsArray(string[] arrayA, string[] arrayB)
{
int j=0;
 for (int i = 0; i < arrayA.Length; i++)
  {
   if(arrayA[i].Length <= 3)
    {
     arrayB[j] = arrayA[i];
     j++;
    }
  }
}

void PrintArrayOnScreen(string[] array)
{
 for(int i = 0; i<array.Length; i++)
  {
   Console.Write(array[i] + " ");
  }
}

ThreeSymbolsArray(array1, array2);
PrintArrayOnScreen(array2);