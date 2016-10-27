using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

	public Text scoreText;
	public Text winText;
	public int score;

	private void Start ()
	{
		score = 0;
		SetScoreText ();
		winText.text = "";

	}

	public void SetScoreText ()
	{
		scoreText.text = "Score: " + score.ToString ();
		if (score >= 12) {
			winText.text = "You Win!";
		}
	}

	public void FixedUpdate ()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
	}

}