using System.Collections;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public static GameController Instance { get; private set; }

    [SerializeField]
    private RetryButtonController retryButtonController;

    void Awake()
    {
        Instance = this;
        retryButtonController.SetActive(false);
    }

    public void GameOver()
    {
        retryButtonController.SetActive(true);
        StartCoroutine("GameOverOverTime");
    }


    IEnumerator GameOverOverTime()
    {
        const float defaultTimeScale = 1f;
        const float timeScaleOnGameOver = 0.25f;

        Time.timeScale = timeScaleOnGameOver;
        yield return new WaitForSeconds(0.5f);
        Time.timeScale = defaultTimeScale;
    }

}
