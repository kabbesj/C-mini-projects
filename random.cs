//random.cs
//This console application simulates 100 tries of the heads and tails game. It counts the number of each and predicts the winner or declares a tie if both win 50 times

using System;

public class random{
	public static void Main(string[] args){
		int x,y;
		y = 0;
		x = 0;
		
		Random random = new Random();
		
		//Console.WriteLine(randomNumber);
		
		for(int i=0;i<100;i++){
			int randomNumber = random.Next(0, 2);
			//Console.WriteLine(randomNumber);
			if(randomNumber == 0){
				x++;
			}
			else{
				y++;
			}
		}
		
		Console.WriteLine("Heads: " + x);
		Console.WriteLine("Tails: " + y);
		
		if(x > y){
			Console.WriteLine("Winner is heads.");
		}
		else if(x < y){
			Console.WriteLine("Winner is tails.");
		}
		else if(x == y){
			Console.WriteLine("TIE!");
		}
		else{
			Console.WriteLine("Something went wrong.");
		}
	}
}