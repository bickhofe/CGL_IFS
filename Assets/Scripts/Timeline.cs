using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class Timeline : MonoBehaviour {

	public PlayableDirector spielberg;

	public void Play () {
		spielberg.Play();
	}

	void Update(){
		if (Input.GetMouseButtonDown(0)){
			Play ();
		}
	}
	

}
