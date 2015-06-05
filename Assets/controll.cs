using UnityEngine;
using System.Collections;
using UnityChan;

public class controll : MonoBehaviour {
	Animator anime;
	UnityChanControlScriptWithRgidBody unitychan;
	// Use this for initialization
	void Start () {
		anime = GetComponent<Animator> ();

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGoal(){
		unitychan.enabled = false;
		anime.SetBool ("Win", true);
	}
}
