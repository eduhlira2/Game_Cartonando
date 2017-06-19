using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barra_Controller : MonoBehaviour {

	public GameObject barraAnimation, vitoria, estados, mapaCompleto;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void Barrinha(){
		barraAnimation.GetComponent<Animator>().Play("Barra_Entra");
	}
	public void BarrinhaSai(){
		barraAnimation.GetComponent<Animator>().Play("Barra_Sai");
	}
	public void AtivarVictory(){
		vitoria.SetActive(true);
		//vitoria.GetComponent<Animator>().Play("Victory_Star");
	}
	public void completarMapa(){
		estados.SetActive(false);
		mapaCompleto.SetActive(true);

	}
}
