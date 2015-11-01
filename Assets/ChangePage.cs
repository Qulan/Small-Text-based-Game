using UnityEngine;
using System.Collections;

public class ChangePage : MonoBehaviour {


	public Texture2D fadeOutTexture;
	public float fadeSpeed;

	private int drawDepth = -1000;

	private float alpha = 1.0f;
	private int fadeDir = -1; // AccelerationEventDirection to fade. = 1 out or in = -1

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	private IEnumerator StartChangePage(string pageName)
	{
		float fadeTime = BeginFade (1);
		yield return new WaitForSeconds (fadeTime);
		Application.LoadLevel (pageName);
		yield return null;	
	}


	public void ChangePageToMenu()
	{
//
//		yield return new WaitForSeconds (fadeTime);
//		Application.LoadLevel ("MenuPage");
		StartCoroutine (StartChangePage("MenuPage"));
		//PresistDuringLoad.Instance.Test ();
	}

	public void ChangePageToCharacterPage()
	{
//		float fadeTime = BeginFade (1);
//		yield return new WaitForSeconds (fadeTime);
//		Application.LoadLevel ("CharacterPage");
		StartCoroutine (StartChangePage("CharacterPage"));
	}


	public float BeginFade(int direction) //Returning fadespeed
	{
		fadeDir = direction;
		return fadeSpeed;
	}
	void OnGUI()
	{
		alpha += fadeDir * fadeSpeed* Time.deltaTime;

		alpha = Mathf.Clamp01 (alpha);


		GUI.color = new Color (GUI.color.r, GUI.color.g, GUI.color.b, alpha);

		GUI.depth = drawDepth;
		GUI.DrawTexture (new Rect (0, 0, Screen.width, Screen.height), fadeOutTexture);
	}
	void OnLevelWasLoaded()
	{
		BeginFade (-1);
	}
}
