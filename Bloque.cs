using UnityEngine;
using System.Collections;

public class Bloque: MonoBehaviour {

	public bool colisionadoConJugador = false;
	public int ganancias = 1;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	//Mejorado
	void OnCollisionEnter2D(Collision2D collision){	//Aumenta la puntuacion por plataforma y no por fotograma en ella
		//Debug.Log(collision.collider.gameObject.name); Nombra la parte qe colisiona
		if (!colisionadoConJugador && (collision.collider.gameObject.name == "PataInferior Izquierda B" || collision.collider.gameObject.name == "PataInferior Derecha B")) {
			NotificationCenter.DefaultCenter().PostNotification(this, "IncrementarPuntos", ganancias);
			colisionadoConJugador = true;
		}
	}/*Video
	void OnCollisionEnter2D(Collision2D collision){	//Aumenta la puntuacion por plataforma y no por fotograma en ella
		if (!colisionadoConJugador && collision.gameObject.tag == "Player") {	
			GameObject obj = collision.contacts[0].collider.gameObject;
			if (obj.name == "PataInferior Izquierda B" || obj.name == "PataInferior Derecha B"){ //Cuidado con cambiar el nombre de los objetos
				colisionadoConJugador = true;
				NotificationCenter.DefaultCenter().PostNotification(this, "IncrementarPuntos", ganancias);
			}
		}
	}*/
}
