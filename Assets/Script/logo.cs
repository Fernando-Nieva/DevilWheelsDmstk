using UnityEngine;
using UnityEngine.SceneManagement;

public class logo : MonoBehaviour
{


	public float duracionIntro = 2f; // Duraci�n total de la animaci�n

	void Start()
	{
		Invoke("CargarEscenaPrincipal", duracionIntro);
	}

	void CargarEscenaPrincipal()
	{
		SceneManager.LoadScene("Intro"); // Reemplaz� con el nombre real de tu escena de juego
	}
}


