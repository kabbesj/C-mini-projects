using System;

namespace ClassExample{
	class item{
	public String name; //Name of item
	public double price; // Price of item
	public double quantity; //Quantity of item
		
		
	///////////PRICE////////////
	public void setPrice(double price) { this.price = price; }
    	public double getPrice() { return this.price; }
		
	////////////QUANTITY////////////
	public void setQuantity(double quantity) { this.quantity = quantity;}
    	public double getQuantity() { return this.quantity; }
	
	///////////TOTAL////////////
	public double getTotal(){ return this.getPrice() * this.getQuantity();}
		
	///////////DISPLAY INFORMATION////////	
		public void display(){
			
			Console.WriteLine("Name: " + this.name);
			Console.WriteLine("Price: $" + this.price);
			Console.WriteLine("Quantity: " + this.quantity);
			Console.WriteLine("Total: $" + this.getTotal().ToString() + "\n");
			
		}	
	}
	
	class itemTest{
		static void Main(string[] args){
	
			item strawberries = new item(); //create new item strawberries
			strawberries.name = "strawberries"; //set name for strawberries
			strawberries.setPrice(2.50); //set price for strawberries
			strawberries.setQuantity(5); //set quantity for strawberries
			strawberries.display(); //Use display method to display information and total price for strawberries
			
			item milk = new item(); //create new item milk
			milk.name = "milk"; //set name for milk
			milk.setPrice(4.35); //set price for milk
			milk.setQuantity(23); //set quantity for milk
			milk.display(); //Use display method to display information and total price for milk
			
			
		}
		
		
		
	}

}
