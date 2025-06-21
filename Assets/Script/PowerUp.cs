using UnityEngine;

public class PowerUp : MonoBehaviour
{


    public GameObject CronometroGo;
	public Cronometro CronometroScript;


	private void Start()
	{
		CronometroGo = GameObject.Find("Cronometro");
		CronometroScript = CronometroGo.GetComponent<Cronometro>();
	}
	private void OnTriggerEnter2D(Collider2D cInfo)
	{
		if (cInfo.gameObject.tag == "coche")
		{
			CronometroScript.tiempo +=10;
			CronometroScript.ImagenMasTiempo();
			gameObject.SetActive(false);

		}
	}




}
