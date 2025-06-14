using System;
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{

	public GameObject motorCarreteras;
	public MotorCarreteras motorCarreterasScript;
	public GameObject coche;


	private void OnTriggerEnter2D(Collider2D cInfo)
	{
		if (cInfo.gameObject.tag == "coche")
		{
			motorCarreterasScript.SpeedArcen();
			coche.GetComponent<AudioSource>().pitch = 1f;
			//Debug.Log("Coche ha entrado en el trigger de ArcenCarreteras");


		}

	}


	void OnTriggerExit2D(Collider2D cInfo)
	{
		if (cInfo.gameObject.tag == "coche")
		{
			{
				motorCarreterasScript.SpeedCarretera();
				coche.GetComponent<AudioSource>().pitch = 1.6f;
				//Debug.Log("Coche ha salido del trigger de ArcenCarreteras");
			}

		}


	}

}
