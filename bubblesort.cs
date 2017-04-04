//bubblesort.cs
// string and integer bubble sorts. Code to find integer currently commented out.

using System;

public class bubblesort{
	public static void Main(){
		//int[] arr = { 100, 200, 300, 400, 500, 600, 700, 800, 900 }; /// for integer sort
		string[] arr = {"detroit lions","green bay packers","chicago bears","minnesota vikings"}; ///for string sort

		//int temp = 0;		///for integer sort
		string temp = ""; /// for string sort

		for (int write = 0; write < arr.Length; write++) {			
			for (int sort = 0; sort < arr.Length - 1; sort++) {				
				//if (arr[sort] > arr[sort + 1])	/// for integer sort			
				if (string.Compare(arr[sort], arr[sort+1]) == 1){ ///for string sort				
					temp = arr[sort + 1];
					arr[sort + 1] = arr[sort];
					arr[sort] = temp;
				}
			}
		}
		for (int i = 0; i < arr.Length; i++){
			Console.Write(arr[i] + " \n");
		}
		Console.ReadKey();
     
	}	
}