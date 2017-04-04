//FindInArray.cs
//App receives input, checks if it's in the array arr[] and then returns true or false. Continues in while loop until user exits.
using System;

public class FindInArray
{
	
	public static class global
		{
			public static int[] arr = {1,2,3,4,5,6,7,8,9,10};
			public static int z;
			public static string x;
			public static int y;
		}

   public static void Main()
   {

	  int input = 0;
	  string input1;
	  
	  while(input != 1){
		System.Console.WriteLine("Enter number to determine if it's in array: ");
		global.x = System.Console.ReadLine();	  
		global.z = Int32.Parse(global.x);
		find();
		Console.WriteLine("\nEnter 1 to exit, any other integer to continue: \n");	
		input1 = System.Console.ReadLine();
		try{
				input = Int32.Parse(input1);
		}
		catch{
			Console.WriteLine("\nInvalid input.\n");
		}  
	  }  
   }
   
	public static void find(){
		for(int i=0; i< global.arr.Length; i++){
		  global.y = global.arr[i];
		  if (global.z == global.y)
		  {
			  System.Console.WriteLine("\nTRUE. The number is in the array. \n");
			  return;
		  }
		  else{  
		  }
		}
		System.Console.WriteLine("\nFALSE. The number is not in the array. \n");
	}
}