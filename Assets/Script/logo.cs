using UnityEngine;
using UnityEngine.SceneManagement;

public class logo : MonoBehaviour
{


	public float duracionIntro = 2f; // Duración total de la animación

	void Start()
	{
		Invoke("CargarEscenaPrincipal", duracionIntro);
	}

	void CargarEscenaPrincipal()
	{
		SceneManager.LoadScene("Intro"); // Reemplazá con el nombre real de tu escena de juego
	}
}


