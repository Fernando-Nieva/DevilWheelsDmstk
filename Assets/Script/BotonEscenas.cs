using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class BotonEscenas : MonoBehaviour
{

	public Image fundido;



	private void OnMouseDown()
	{
		this.gameObject.GetComponent<SpriteRenderer>().color = new Color(0.3f, 0.3f, 0.3f, 1); // Cambia el color del sprite al hacer clic
		this.gameObject.GetComponent<AudioSource>().Play(); // Reproduce el sonido al hacer clic

	}
	private void OnMouseOver()
	{
		this.gameObject.GetComponent<SpriteRenderer>().color = new Color(0.5f, 0.5f, 0.5f, 1); // Cambia el color del sprite al hacer clic


	}
	private void OnMouseExit()
	{
		this.gameObject.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1); // Cambia el color del sprite al hacer clic


	}
	private void OnMouseUp()
	{
		
		this.gameObject.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1); // Cambia el color del sprite al hacer clic
		this.gameObject.GetComponent<BoxCollider2D>().enabled = false; // Desactiva el collider para evitar múltiples clics
		fundido.CrossFadeAlpha(1,0.5f,false);
		StartCoroutine(CargoEscena());


	}

	IEnumerator CargoEscena()

	{
		yield return new WaitForSeconds(1);
		SceneManager.LoadScene("Juego");
	}






}