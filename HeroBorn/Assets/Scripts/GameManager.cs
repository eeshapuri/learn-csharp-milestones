using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI gameStatusText;
    public TextMeshProUGUI winText;

    public static GameManager I { get; private set; }
    [SerializeField] private int _score = 0;
    [SerializeField] private int _playerHealth = 100;
    [SerializeField] private int targetScore = 3;

    void Awake()
    {
        if (I == null) I = this;
        else { Destroy(gameObject); return; }
    }

    void Start()
    {
        Time.timeScale = 1f;

        if (winText != null)
            winText.gameObject.SetActive(false);
        UpdateHUD();
    }
    public int Score
    {
        get => _score;
        set
        {
            _score = value;
            UpdateHUD();
        }
    }
    public int PlayerHealth
    {
        get => _playerHealth;
        set
        {
            _playerHealth = value;
            UpdateHUD();
        }
    }
    void UpdateHUD()
    {
        if (gameStatusText != null)
            gameStatusText.text = $"Health: {_playerHealth} Score: {_score}";
    }

    public void ShowWin()
    {
        if (winText != null)
            winText.gameObject.SetActive(true);
    }

    public void AddScore(int amount = 1)
    {
        Score += amount;
        if (Score >= targetScore) WinGame();
    }

    public void DamagePlayer(int amount = 10)
    {
        PlayerHealth = MathF.Max(0, PlayerHealth - amount);
    }

    void WinGame()
    {
        ShowWin();
        Time.timeScale = 0f;
    }

    public void HideWinAndResume()
    {
        if (winText != null) winText.gameObject.SetActive(false);
        Time.timeScale = 1f;
    }
}