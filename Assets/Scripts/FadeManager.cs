using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeManager : MonoBehaviour {

	/*public Image image;
	public float time;
	private Color color;

	void Start()
	{
		image = gameObject.GetComponent<Image> ();
		StartCoroutine (FadeIn ());

	}

	IEnumerator FadeIn()
	{
		Color color = image.color;
		while (image.color.a > 0) 
			{
			color.a -= Time.deltaTime / time;
				image.color = color;
		}
		yield return null;
	}

	IEnumerator FadeOut()
	{
		Color color = image.color;
			while (image.color.a < 1)
			{
				color.a += Time.deltaTime / time;
				image.color = color;
			}
		yield return null;
	}
}*/

/*	private Image image;

	void Start (){
		image = gameObject.GetComponent<Image>();
		StartCoroutine(FadeIn());

	}

	IEnumerator FadeIn(){
		float time = 2f;
		Color color = image.color;
		while (image.color.a > 0) {
			color.a -= Time.deltaTime / time;
			image.color = color;
			yield return null;
		}
	}

	IEnumerator FadeOut()
	{
		float time = 2f;
		Color color = image.color;
		while(image.color.a < 1)
		{
			color.a += Time.deltaTime / time;
			image.color = color;
			yield return null;
		}
	}
}
*/