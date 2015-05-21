using UnityEngine;
using System.Collections;

public class Scroll : MonoBehaviour {

	public float velocidad = 0f;
	public bool enMovimiento = false;
	public float tiempoInicio = 0f;
	public bool iniciarEnMovimiento = false;

	// Use this for initialization
	void Start () {
		NotificationCenter.DefaultCenter().AddObserver(this, "PersonajeEmpiezaACorrer");
		NotificationCenter.DefaultCenter().AddObserver(this, "PersonajeHaMuerto");
		if(iniciarEnMovimiento){
			PersonajeEmpiezaACorrer();
		}
	}
	void PersonajeHaMuerto(){
		enMovimiento = false;	
	}

	void PersonajeEmpiezaACorrer(){
		enMovimiento = true;
		tiempoInicio = Time.time;
	}

	// Update is called once per frame
	void Update () {
		if(enMovimiento){
			renderer.material.mainTextureOffset = new Vector2(((Time.time - tiempoInicio) * velocidad)%1, 0);
		}
	}
}
