using UnityEngine;
using System.Collections;

public class Item : MonoBehaviour {

	public int ganancias = 5;
	public AudioClip itemSoundClip;	//Otra forma de reproducir audios
	public float itemSoundVolume = 1f;	//

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D (Collider2D collider){
		if (collider.tag == "Player"){
			NotificationCenter.DefaultCenter().PostNotification(this, "IncrementarPuntos", ganancias);
			AudioSource.PlayClipAtPoint (itemSoundClip, Camera.main.transform.position, itemSoundVolume); //
		}
		Destroy (gameObject);
	}
}