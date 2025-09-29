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
