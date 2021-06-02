/// Reverse a Array 

using System;

public class Program
{
	static void reversearr(int [] arr , int start ,int end){
	int temp ;
		while(start < end)
		{
		  temp = arr[start];
		 arr[start] = arr[end];
		  arr[end]= temp;
		  start++;
		  end-- ;
		}
	
	}
	static void printarr(int []arr , int size){
	 for (int i = 0 ; i< size ; i++){
	 Console.Write(arr[i] + " ");
         
        Console.WriteLine();
	 }
	}
	public static void Main()
	{
		int []arr = {1,2,3,4,5,6};
		printarr(arr,arr.Length);
		reversearr(arr,0,(arr.Length-1));
		Console.WriteLine("Reverse Array");
		printarr(arr,arr.Length);
		
	}
}
