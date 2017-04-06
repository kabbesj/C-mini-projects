////Polymorphism.cs

using System;
namespace Polymorphism
{

 class item 
   {
      protected double price, quantity;
      public item( double a=0, double b=0)
      {
         price = a;
         quantity = b;
      }
    
	 public virtual double total()
      {
         Console.WriteLine("Parent class total: ");
         return 0;
      }
	  
	  
   }
   
   ///////////////////////////
   
   class bread: item
   {
      public bread( double a=0, double b=0): base(a, b)
      {

      }
	  
      public override double total()
      {
         Console.WriteLine("Bread on sale total price :");
         return ((price * 0.75) * quantity); //bread on sale at 25-percent off
      }
	  
   }
   
   ///////////////////////////////////////
   
   class cheese: item
   {
      public cheese( double a=0, double b=0): base(a, b)
      {

      }
	  
      public override double total()
      {
         Console.WriteLine("Cheese on sale total price :");
         return ((price * 0.9) * quantity);  //cheese on sale at 10-percent off
      }
	  
   }
   
   //////////////////////////////////////
   class display
   {
      public void displayTotal(item it)
      {
         double a;
         a = it.total();
         Console.WriteLine("$" + a);
      }
   }  
   /////////////////////////////////////
   
   class mainFunctionClass
   {
      
      static void Main(string[] args)
      {
         display d = new display();
         bread b = new bread(2, 5); ///Bread originally at $2 and 5 loaves
         cheese ch = new cheese(5, 6); //Cheese originally at $5 and 6 blocks
         d.displayTotal(b);
         d.displayTotal(ch);
         Console.ReadKey();
      }
   }
}

