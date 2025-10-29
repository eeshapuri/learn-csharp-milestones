using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int _score;
    public int Score
    {
        get { return _score; }
        set
        {
            _score = value;
            Debug.Log("Score updated: " + _score);
        }
    }
    private int _playerHealth = 100;
    public int PlayerHealth
    {
        get { return _playerHealth; }
        set
        {
            _playerHealth = value;
            if (_playerHealth <= 0)
            {
                Debug.Log("Game Over!");
            }
        }
    }
    void Start()
    {
        Score = 0;
        Debug.Log("And we begin! Score = " + Score + ", Health = " + PlayerHealth);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Score += 10;
        }
        if (Input.GetKeyDown(KeyCode.H))
        {
            PlayerHealth -= 10;
        }
    }
}