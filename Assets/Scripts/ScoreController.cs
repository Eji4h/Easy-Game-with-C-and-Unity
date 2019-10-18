using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    public static ScoreController Instance { get; private set; }

    [SerializeField]
    private int score;

    [SerializeField]
    private Text scoreLabel;


    void Awake()
    {
        Instance = this;
    }

    public void IncreaseScore(int increateScore)
    {
        score += increateScore;
        scoreLabel.text = $"{score}";
    }
}
