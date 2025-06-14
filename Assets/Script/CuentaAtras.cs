using System.Collections;
using UnityEngine;

public class CuentaAtras : MonoBehaviour
{
	public GameObject motorCarreteras;
	public GameObject musicaJuego;
	public GameObject sonidoStart;
	public GameObject sonidoMotorCoche;
	public GameObject numeros;
	public Sprite[] numerosIMG;

	public MotorCarreteras motorCarreterasScript;
	public Cronometro cronometroScript;

	public bool parararCuenta = false;
	public bool finContador = false;

	public AudioSource reproductor;
	public AudioClip[] sonidosContador;

	private float tiempoDeEspera = 4;

	private void Start()
	{
		reproductor = this.gameObject.GetComponent<AudioSource>();
		//IniciarCuentaAtras();
	}

	public void IniciarCuentaAtras()
	{
		StartCoroutine(EmpezarCuentaAtras());
	}

	private IEnumerator EmpezarCuentaAtras()
	{
		sonidoStart.GetComponent<AudioSource>().Play();
		yield return new WaitForSeconds(1);
		InvokeRepeating("Contando", 0f, 1f);
	}

	void Contando()
	{
		tiempoDeEspera--;

		if (tiempoDeEspera >= 3)
		{
			numeros.GetComponent<SpriteRenderer>().sprite = numerosIMG[2];
			reproductor.clip = sonidosContador[0];
			reproductor.Play();
		}
		else if (tiempoDeEspera >= 2)
		{
			numeros.GetComponent<SpriteRenderer>().sprite = numerosIMG[1];
			reproductor.clip = sonidosContador[0];
			reproductor.Play();
		}
		else if (tiempoDeEspera >= 1 && !finContador)
		{
			numeros.GetComponent<SpriteRenderer>().sprite = numerosIMG[0];
			reproductor.clip = sonidosContador[1];
			reproductor.Play();

			// Iniciar juego
			finContador = true;
			cronometroScript.cronometroEncendido = true;
			motorCarreterasScript.CuentaRegresivaTermino = true;

			musicaJuego.GetComponent<AudioSource>().Play();
			sonidoMotorCoche.GetComponent<AudioSource>().Play();
		}
		else if (tiempoDeEspera <= 0)
		{
			numeros.SetActive(false);
			CancelInvoke("Contando");
		}
	}


	private void Update()
	{
		if (tiempoDeEspera==0 && parararCuenta==false)
		{
			parararCuenta= true;
			numeros.SetActive(false);
		}

	}
}
