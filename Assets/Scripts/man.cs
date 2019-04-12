using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class man : MonoBehaviour {

	public string SceneState = "";
    public bool hasDecided = false;
	public GameObject Energybar;
	public Animator anim;
	// Use this for initialization
	void Start () {
		transform.position = new Vector3(0,0,0);
		anim = GetComponent<Animator>();
        Intro();
	}
	
	// Update is called once per frame
	void Update () {
		if (SceneState == "Action" && hasDecided == false){
			Vector3 BarSize = Energybar.transform.localScale;
            BarSize.x -= Time.deltaTime/5;
            Energybar.transform.localScale = BarSize;

            if (Input.GetKeyDown(KeyCode.Y))
            {
                anim.SetTrigger("positive");
                hasDecided = true;
            }

            if (Input.GetKeyDown(KeyCode.N))
            {
                anim.SetTrigger("negative");
                hasDecided = true;
            }

		}
        
	}

	void Intro(){
		print("intro");
        SceneState = "Intro";
		Invoke("Action",5);
	}

	void Action(){
		print("action");
        SceneState = "Action";
        Invoke("CheckDeath", 5);

	}

	void CheckDeath(){
        Energybar.SetActive(false);
		if (hasDecided == false) Destroy(gameObject);
		else print(hasDecided);
	}
}
