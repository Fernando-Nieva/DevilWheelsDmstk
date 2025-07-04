using UnityEngine;
using System.Collections;
using TMPro;
using UnityEngine.UI; // <-- Agrega esta l�nea

public class Cronometro : MonoBehaviour
{
	public GameObject motorCarretera;
	public MotorCarreteras motorCarreterasScript;

	public TextMeshProUGUI textoTiempo;
	public TextMeshProUGUI textoMetros;

	public float distancia;
	public float tiempo;

	public bool cronometroEncendido;
	public Image masTiempo;

	public GameObject popGameOverGo;
	public PopGameOver popGameOverScript;



	void Start()
	{
		textoTiempo.text = "1:30";
		textoMetros.text = "0";
		masTiempo.CrossFadeAlpha(0, 0, false);
	}

	void Update()
	{
		if (motorCarreterasScript.juegoTerminado == false && cronometroEncendido == true)
		{
			distancia += Time.deltaTime * motorCarreterasScript.speed;
			textoMetros.text = ((int)distancia).ToString();

			tiempo -= Time.deltaTime;
			int minutos = (int)(tiempo / 60);
			int segundos = (int)(tiempo % 60);
			textoTiempo.text = minutos.ToString()+":"+segundos.ToString().PadLeft(2,'0');

		}

		if(tiempo<=0.00f && motorCarreterasScript.juegoTerminado == false)
		{
			motorCarreterasScript.juegoTerminado = true;
			popGameOverGo.SetActive(true);
			popGameOverScript.ActivoGameOver();
			Debug.Log("Juego Terminado por tiempo");

		}

	}




	public void ImagenMasTiempo()
	{
		masTiempo.CrossFadeAlpha(1, 0.5f, false);
		this.gameObject.GetComponent<AudioSource>().Play();
		StartCoroutine(CierroImagenMastiempo());
	}

	IEnumerator CierroImagenMastiempo()
	{
		yield return new WaitForSeconds(1);
		masTiempo.CrossFadeAlpha(0, 0.5f, false);
	}





}
