/// Min and max from array

using System;
					
public class Program
{
	 public class pair {
	    public int min;
        public int max;
	}
	
	static pair getMinMax(int []arr , int size){
		pair minmax = new pair();
		int i;
	    if (arr[0] > arr[1]){
		   minmax.max = arr[0];
		   minmax.min = arr[1];
		}
		else
		{
		  minmax.max = arr[1];
		   minmax.min = arr[0];
		}
		
		for (i = 2 ; i < size ; i++){
		 if(arr[i]< minmax.min){
		  minmax.min = arr[i];
		 }
		 if(arr[i] > minmax.max){
		  minmax.max = arr[i];
		 }
		}
		
		return minmax;
	
	}
	public static void Main()
	{
		int []arr = {1000, 11, 445, 1, 330, 3000};
        int arr_size = 6;
        pair minmax = getMinMax(arr, arr_size);
		Console.WriteLine("max value " + minmax.max);
			Console.WriteLine("min value " + minmax.min);
	}
}