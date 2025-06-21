using UnityEngine;

public class cocheMalo : MonoBehaviour
{
	public GameObject motorCarreteras;
	public MotorCarreteras motorCarreterasScript;
	public GameObject coche;







	private void Start()
	{
		motorCarreteras = GameObject.Find("MotorCarreteras");
		motorCarreterasScript = motorCarreteras.GetComponent<MotorCarreteras>();
		coche = GameObject.Find("coche");
	}
	private void OnCollisionEnter2D(Collision2D cInfo)
	{ 
	
		if (cInfo.gameObject.tag == "coche")
		{
			motorCarreterasScript.SpeedCocheMalo();
			coche.GetComponent<AudioSource>().pitch = 1f;
			Debug.Log("Coche ha entrado en el collision de ArcenCarreteras");
		this.gameObject.GetComponent<AudioSource>().Play(); // Reproduce el sonido al entrar en la colisión


		}

	}


	void OnCollisionExit2D(Collision2D cInfo)
	{
		if (cInfo.gameObject.tag == "coche")
		{
			{
				motorCarreterasScript.SpeedCarretera();
				coche.GetComponent<AudioSource>().pitch = 1.6f;
				Debug.Log("Coche ha salido del collision de ArcenCarreteras");
			}

		}


	}
}
