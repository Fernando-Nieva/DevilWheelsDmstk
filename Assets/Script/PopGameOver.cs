using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using System.Collections;

public class PopGameOver : MonoBehaviour
{
	public Image BGpop;
	public Image imgPop;
	public Button botonReiniciar;
	public TextMeshProUGUI metrosRecorridos;
	public GameObject popGameOverGo;
	public Image imagenFundido;
	public Cronometro cronometroScript;
	public GameObject musicaJuego;
	public AudioClip musicaGameOver;
	public GameObject Coche;

	void Start()
	{
		popGameOverGo.SetActive(false);
	}

	public void ActivoGameOver()
	{
		musicaJuego.GetComponent<AudioSource>().clip = musicaGameOver;
		musicaJuego.GetComponent<AudioSource>().Play();
		botonReiniciar.gameObject.SetActive(true);
		BGpop.CrossFadeAlpha(1, 0.3f, false);
		imgPop.CrossFadeAlpha(1, 0.3f, false);
		Coche.GetComponent<AudioSource>().Stop();

		// Si querés fade en texto, usar CanvasGroup. Por ahora se comenta:
		// metrosRecorridos.CrossFadeAlpha(1, 0.3f, false);

		metrosRecorridos.text = ((int)cronometroScript.distancia).ToString() + " mts";
	}

	public void ReinicioJuego()
	{
		imagenFundido.CrossFadeAlpha(1, 0.3f, false);
		StartCoroutine(CargoEscena());
	}

	IEnumerator CargoEscena()
	{
		yield return new WaitForSeconds(1);
		SceneManager.LoadScene("Juego");
	}
}
