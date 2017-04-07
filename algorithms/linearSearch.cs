 using System;
 
 public class linearSearch{
	public static int[] data = {1,2,3,4,5,6,7,8,9};
	
	static void Main(string[] args){
		int number = 0;
		
		
		Console.Write("\nEnter a number to determine if it's in the array: ");
		string n = Console.ReadLine();
		
		try{
			number = Int32.Parse(n);
			
			for(int i=0;i<data.Length;i++){
				if(data[i] == number){
					Console.Write("The linear search determined the value is in the array. \n");
					return;
				}
				if(data[i] == data.Length){
					Console.Write("The number is not in the array. \n");
				}
			}
			
		}
		catch{
			Console.Write("You may have entered invalid input. \n");
		}
		
		
		
		
	}
 }
