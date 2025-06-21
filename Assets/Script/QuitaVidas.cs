using UnityEngine;

public class QuitaVidas : MonoBehaviour
{

    public GameObject VidasGO;
	public Vidas vidasScript;


	private void Start()
	{
		VidasGO = GameObject.Find("Vidas");
		vidasScript = VidasGO.GetComponent<Vidas>();
	}
	
	private void OnTriggerEnter2D(Collider2D cInfo)
	{
		if (cInfo.gameObject.tag == "coche")
		{
			
			vidasScript.contadorVidas = vidasScript.contadorVidas - 1;
			vidasScript.ImagenMenosVida();
			gameObject.SetActive(false);


		}
		
		

	}





}
