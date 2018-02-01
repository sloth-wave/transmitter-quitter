using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreditsScript : MonoBehaviour 
{
	public Text titleText;
	public Text creditsText;
	public float speed = 0.1f;

	private RectTransform titleRect;
	private RectTransform creditsRect;
	private float yPos;

	void Start()
	{	
		titleRect = titleText.GetComponent<RectTransform>();
		creditsRect = creditsText.GetComponent<RectTransform>();
		StartCoroutine(ScrollUp());
	}

	public IEnumerator FadeIn() 
	{
		titleText.color = new Color(titleText.color.r, titleText.color.g, titleText.color.b, 0);
        while (titleText.color.a < 1.0f)
        {
            titleText.color = new Color(titleText.color.r, titleText.color.g, titleText.color.b, titleText.color.a + (Time.deltaTime / speed));
            yield return null;
        }
	}

	public IEnumerator ScrollUp()
	{
		yield return FadeIn();
		yield return new WaitForSeconds(1);
		StartCoroutine(Scroll());
		
	}

	IEnumerator Scroll()
	{
		Vector2 endingPosition01 = new Vector2(0.0f, 643.0f);
		Vector2 endingPosition02 = new Vector2(0.0f, 330.0f);

		float time = 20.0f;
		float elaspedTime = 0f;
		Vector2 startingPosition01 = titleRect.anchoredPosition;
		Vector2 startingPosition02 = creditsRect.anchoredPosition;
		
		// print(startingPosition01 + "::::" + startingPosition02);
		
		while(elaspedTime < time)
		{
			titleRect.anchoredPosition = Vector2.Lerp(startingPosition01, endingPosition01, (elaspedTime/time));
			creditsRect.anchoredPosition = Vector2.Lerp(startingPosition02, endingPosition02, (elaspedTime/time));

			elaspedTime += Time.deltaTime;
			yield return null;
		}
	}
}
