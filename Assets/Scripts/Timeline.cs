using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class Timeline : MonoBehaviour {

	public PlayableDirector spielberg;

    public PlayableDirector[] MyTimelineComponents;

	public bool bulletTime = false;

	public void Play () {
		spielberg.Play();
	}

	public void Stop () {
		spielberg.time = 0;
		spielberg.Evaluate();
		spielberg.Stop();
	}

	public void Pause () {
		spielberg.Pause();
	}

	public void Slow () {
		spielberg.timeUpdateMode = DirectorUpdateMode.Manual;
		spielberg.time += Time.deltaTime/10;
		spielberg.Evaluate();
	}

	public void Fast () {
		spielberg.timeUpdateMode = DirectorUpdateMode.Manual;
		spielberg.time += Time.deltaTime*2;
		spielberg.Evaluate();
	}

	public void Normal () {
		spielberg.Pause();
		spielberg.timeUpdateMode = DirectorUpdateMode.GameTime;
		spielberg.Play();
	}

	void Update(){
		if (Input.GetMouseButtonDown(0)){
			Play ();
		}

		if (Input.GetMouseButtonDown(1)){
			Stop ();
		}

		// if (Input.GetMouseButtonDown(2)){
		// 	Pause ();
		// }

		if (Input.GetMouseButtonDown(2)){
			bulletTime = true;
		}

		if (Input.GetMouseButtonUp(2)){
			bulletTime = false;
			Normal ();
		}

		if (bulletTime) Slow ();
	}
	

}
