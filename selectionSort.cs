using System;

namespace selectionSort
{
	
    class Program
    {
		public static int[] data = {44, 67, 33, 20, 1};
		static void Main(string[] args)
        {			
			Sort();
			Console.WriteLine("Array sorted by selection sort: ");
			
			for(int i=0;i<data.Length;i++){
				Console.Write(data[i] + " ");
			}
        }
		
		 public static void Sort()
        {
			int smallest; 
            for (int i = 0; i < data.Length - 1; i++) //loops number of iterations equalling (data.Length - 1)
            {
                smallest = i; //placeholder for smallest number

                for (int index = i + 1; index < data.Length; index++) //cycle through array to determine if there's a smaller remaining number
                {
                    if (data[index] < data[smallest]) //determine if the current number in loop is smallest and if so assign to variable smallest.
                    {
                        smallest = index; 
                    }
                }
                Swap(i, smallest); //use Swap() to switch out the index, i, with the smallest number remaining.
		   }
            	
        }

        public static void Swap(int num1, int num2)
        {
            int temp = data[num1];  //placeholder variable to hold value of data[num1] while switching values  
            data[num1] = data[num2];  //switch
            data[num2] = temp;  //data[num2] now takes the value of what was data[num1] 
        }     
    }

    
}
