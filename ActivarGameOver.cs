using UnityEngine;
using System.Collections;

public class ActivarGameOver : MonoBehaviour {

	public GameObject camaraGameOver;
	public AudioClip gameOverClip;


	// Use this for initialization
	void Start () {
		NotificationCenter.DefaultCenter ().AddObserver (this, "PersonajeHaMuerto");
	}
	void PersonajeHaMuerto(Notification notificacion){
		audio.Stop ();
		audio.clip = gameOverClip;
		audio.loop = false;
		audio.volume = 0.3f;
		audio.pitch = 0.8f;
		audio.Play ();
		camaraGameOver.SetActive (true);
	}

	// Update is called once per frame
	void Update () {
	
	}
}
