
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

	public Text countText;
	public Text winText;
	public int count;

	private void Start ()
	{
		count = 0;
		SetCountText ();
		winText.text = "";

	}

	public void SetCountText ()
	{
		countText.text = "Count: " + count.ToString ();
		if (count >= 12) {
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