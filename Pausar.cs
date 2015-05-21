using UnityEngine;
using System.Collections;

public class Pausar : MonoBehaviour {

	bool pausa = false;
	int contador = 1;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(contador%2==0){
			pausa=true;
		}else{
			pausa=false;
		}
	}	
	
	void OnMouseDown(){
		if(pausa==false){
			Camera.main.audio.Stop ();
			//gameObject.rigidbody2D.audio.Stop ();
			audio.Play ();
			Time.timeScale = 0;	
			contador++;
		}else{
			Camera.main.audio.Play ();
			//gameObject.rigidbody2D.audio.Stop ();
			audio.Play ();
			Time.timeScale = 1;
			contador++;
		}
	}
}
