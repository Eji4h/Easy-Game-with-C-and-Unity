using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RetryButtonController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var retryButton = GetComponent<Button>();
        retryButton.onClick.AddListener(() =>
        {
            const float defaultTimeScale = 1f;
            Time.timeScale = defaultTimeScale;
            SceneManager.LoadSceneAsync("SampleScene");
        });
    }

    public void SetActive(bool isActive)
    {
        gameObject.SetActive(isActive);
    }
}
