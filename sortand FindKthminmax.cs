using System;
					
public class Program
{
	static void sortArray(int[] arr){
	Array.Sort(arr);
  
        // reverse array
       
  
        // print all element of array
        foreach(int value in arr)
        {
            Console.Write(value + " ");
        }
	}
	
	public static void Main()
	{
		int[] arr = new int[] {1, 9, 6, 7, 5, 9};
		sortArray(arr);
	}
}