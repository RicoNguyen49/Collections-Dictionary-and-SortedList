using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a Dictionary<TKey, TValue>
        Dictionary<int, string> myteam = new Dictionary<int, string>();

        // Add 5 items to the dictionary
        myteam.Add(1, "fin the human");
        myteam.Add(2, "jake the dog");
        myteam.Add(3, "simon");
        myteam.Add(4, "marcilean");
        myteam.Add(5, "princess bubblegum");

        Console.WriteLine("USING DICTIONARY");

        // Retrieve and display all the keys

        Console.WriteLine("keys in my team Dictionary:");
        foreach (int key in myteam.Keys)
        {
            Console.WriteLine(key);
        }

        // Retrieve and display all the values
        Console.WriteLine("\nValues in my team Dictionary:");
        foreach (string value in myteam.Values)
        {
            Console.WriteLine(value);
        }

        // Retrieve and display both the keys and the values
        Console.WriteLine("\nKeys and Values in my team Dictionary:");
        foreach (KeyValuePair<int, string> kvp in myteam)
        {
            Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
        }

        // Remove an item from the dictionary
        myteam.Remove(3);
        myteam.Remove(2);


        //display after removing members
        Console.WriteLine("\nKeys and Values in my team Dictionary after removing:");
        foreach (KeyValuePair<int, string> kvp in myteam)
        {
            Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
        }

        // Display a count of the dictionary items
        Console.WriteLine("\nCount of items in the dictionary: " + myteam.Count);



        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");



        // Create a SortedList<TKey, TValue>
        SortedList<int, string> Soccerteam = new SortedList<int, string>();

        // Add players to the sorted list
        Soccerteam.Add(5, "Ronaldo");
        Soccerteam.Add(3, "vini jr");
        Soccerteam.Add(1, "Messi");
        Soccerteam.Add(4, "foden");
        Soccerteam.Add(2, "neymar jr");

        Console.WriteLine(" USING SORTEDLIST");
        // Allow the user to enter a key and value
        Console.WriteLine("Enter a key:");
        int newKey = int.Parse(Console.ReadLine());

        // Check if the key already exists in the sorted list
        if (Soccerteam.ContainsKey(newKey))
        {
            Console.WriteLine("Key already exists. Enter a different key:");
            newKey = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Enter a soccer player name:");
        string newValue = Console.ReadLine();

        // Add the new key-value pair to the sorted list
        Soccerteam.Add(newKey, newValue);

        // Print the key and value for the sorted list
        Console.WriteLine("\nSorted List:");
        foreach (KeyValuePair<int, string> kvp in Soccerteam)
        {
            Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
        }

        // Remove an player from the list
        Console.WriteLine("\nEnter the key to remove a player from the list:");
        int keyToRemove = int.Parse(Console.ReadLine());
        if (Soccerteam.ContainsKey(keyToRemove))
        {
            Soccerteam.Remove(keyToRemove);
            Console.WriteLine($"Player with key {keyToRemove} removed successfully.");
        }
        else
        {
            Console.WriteLine($"Player with key {keyToRemove} does not exist in the list.");
        }
        // Print the key and value for the sorted list
        Console.WriteLine("\nSorted List after player was removed:");
        foreach (KeyValuePair<int, string> kvp in Soccerteam)
        {
            Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
        }
    }



}
