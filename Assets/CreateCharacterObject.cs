using UnityEngine;
using System.Collections;

public class CreateCharacterObject : MonoBehaviour {
	GameObject go;
	// Use this for initialization
	void Start () {
		if(GameObject.Find ("CharacterObject(Clone)") == null && go == null)
			Instantiate(Resources.Load("CharacterObject"));
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
