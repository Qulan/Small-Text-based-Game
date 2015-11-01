using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		tcpClient.Instance.setupSocket ();
		tcpClient.Instance.writeSocket ("HELLO server");
	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log (tcpClient.Instance.readSocket ());
	}
}
