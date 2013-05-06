using UnityEngine;
using System.Collections;

public class script_main_menu : MonoBehaviour {
	private script_persistent persistent;
	
	
	// Use this for initialization
	void Start () {
		persistent = GameObject.Find("Persistent").gameObject.GetComponent<script_persistent>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnGUI() {
		if (GUI.Button(new Rect(Screen.width/2 - 50, Screen.height/2 - 25, 100, 50), "Start")) {
			persistent.current_level = 1;
			Application.LoadLevel(1);
		}
	}
}
