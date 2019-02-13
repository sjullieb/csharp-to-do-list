using System;
using System.Collections.Generic;

namespace ToDoList.Models
{
  public class Program
  {

    public static void Main(){
      Console.WriteLine("Welcome to the To Do List.");
      Menu();
    }
    public static void Menu()
    {
      Console.WriteLine("Would you like to add an item to your list or view your list? [A]dd/[V]iew");

      string action = Console.ReadLine().ToUpper();

      if (action == "A")
      {
        Console.WriteLine("Please enter the description for the new item.");
        string newItemDescription = Console.ReadLine();
        Item newItem = new Item(newItemDescription);

        Console.WriteLine("'" + newItem.GetDescription() + "' has been added to your list.");
        Menu();
      }
      else if (action == "V")
      {
        List<Item> allToDoItems = Item.GetAll();
        if (allToDoItems.Count != 0)
        {
          foreach(Item item in allToDoItems)
          {
            Console.WriteLine((allToDoItems.IndexOf(item) + 1).ToString() + ". " + item.GetDescription());
          }
        }
        else
        {
          Console.WriteLine("You have no items in the list.");
        }
        Menu();
      }
      else
      {
        Console.WriteLine("Goodbye!");
      }
    }
  }
}
