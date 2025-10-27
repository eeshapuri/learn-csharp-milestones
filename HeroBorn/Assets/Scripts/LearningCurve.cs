using System.Diagnostics;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    //Chapter 3, Access modifiers
    public int maxHealth = 100;
    private float speed = 3.5f;
    public string playerName = "Ferrone";
    private bool hasKey = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int myInt = 40;
        float myFloat = 3.2f;
        string myString = "Hi Unity";
        bool myBool = true;

        //single line comment

        /*multi-line 
            comment*/

        ///<summary>
        /// summary for chapter 2
        /// </summary>

        // Chapter 3, Logging variables to console and concatenating strings using operators/string interpolation
        Debug.Log("Player Level (Ch2 myInt): " + myInt);
        Debug.LogFormat("Run speed is {0}", speed);
        Debug.Log($"Player {playerName} has key? {hasKey}");

        //Chapter 3, Methods
        Greet(playerName);
        int sum = Add(2, 3);
        Debug.Log($"Sum is {sum}");

        //Chapter 4, Conditionals
        if (maxHealth > 80)
        {
            Debug.Log("Player is healthy");
        }
        else if (maxHealth > 50)
        {
            Debug.Log("Player is okay");
        }
        else
        {
            Debug.Log("Player needs healing");
        }

        //Chapter 4, testing for [true] and [true!]
        if (hasKey)
        {
            Debug.Log("Door unlocked!");
        }
        if (!hasKey)
        {
            Debug.Log("Door locked.");
        }

        //Chapter 4, nested if statement
        if (playerName == "Ferrone")
        {
            if (hasKey)
            {
                Debug.Log("Ferrone can open the door.");
            }
            else
            {
                Debug.Log("Ferrone can't open the door yet.");
            }
        }

        // Ch4, Switch Statement
        switch (maxHealth)
        {
            case 100:
                Debug.Log("Full health!");
                break;
            case 50:
                Debug.Log("Half health!");
                break;
            default:
                Debug.Log("Some other health value.");
                break;
        }

        // Ch 4, Collection: Array of ints
        int[] scores = { 90, 85, 100, 75 };
        Debug.Log($"First score: {scores[0]}");

        // Ch 4, Collection: List of strings
        List<string> inventory = new List<string>();
        inventory.Add("Sword");
        inventory.Add("Shield");
        inventory.Add("Potion");

        Debug.Log($"You have {inventory.Count} items in your inventory.");

        // Ch 4, Collection: Dictionary
        Dictionary<string, int> playerStats = new Dictionary<string, int>();
        playerStats.Add("Strength", 15);
        playerStats.Add("Agility", 12);
        playerStats.Add("Intelligence", 10);

        Debug.Log($"Player strength is {playerStats["Strength"]}");

        // Ch4, Loops
        for (int i = 0; i < inventory.Count; i++)
        {
            if (i == 1)
            {
                Debug.Log($"Item at index {i}: {inventory[i]}");
            }
        }

        foreach (string item in inventory)
        {
            Debug.Log($"Inventory contains: {item}");
        }

        foreach (KeyValuePair<string, int> stat in playerStats)
        {
            Debug.Log($"{stat.Key}: {stat.Value}");
        }

        // Chapter 5, Classes
        Character hero = new Character("Eleanor", 5);
        Character heroine = new Character("Tima", 7);

        Debug.Log($"Hero: {hero}");
        Debug.Log($"Heroine: {heroine}");

        // === Chapter 5: Structs ===
        Weapon huntingBow = new Weapon("Hunting Bow", 35);
        Weapon warBow = new Weapon("War Bow", 50);

        Debug.Log($"Weapon 1: {huntingBow}");
        Debug.Log($"Weapon 2: {warBow}");
    }

    void Greet(string name)
    {
    Debug.Log($"Hello, {name}!");
    }

    int Add(int a, int b)
    {
    return a + b;
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}