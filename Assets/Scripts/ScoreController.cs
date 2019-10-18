using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
	[SerializeField]
	private Text scoreLabel;

	public void SetScore(int val)
	{
		scoreLabel.text = $"{val}";
	}

}
