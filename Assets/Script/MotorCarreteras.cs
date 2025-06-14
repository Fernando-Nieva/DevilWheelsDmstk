using UnityEngine;

public class MotorCarreteras : MonoBehaviour

{


    public GameObject motorCarreteras;
	public GameObject[] contenedorCalles;

    public float speed = 5f;
    
    public int numSelectorDeCalles = 0;
	public int contadorCalles = 0;

    public bool CuentaRegresivaTermino;
	public bool juegoTerminado;

	void Start()
    {

        juegoTerminado = false;
        InicioJuego();
	}

    void Update()
    {

        if(CuentaRegresivaTermino && !juegoTerminado)
        {

			motorCarreteras.transform.Translate(Vector3.down * speed * Time.deltaTime);
        }

	}

    public void InicioJuego()
    {
        CreaCalles();
        SpeedCarretera();
		CuentaRegresivaTermino = false;
	}

    public void CreaCalles()
    {
		numSelectorDeCalles = Random.Range(0,5);
        GameObject Calle = (GameObject)Instantiate(contenedorCalles[numSelectorDeCalles], new Vector3(0, 50, 0), transform.rotation);

        Calle.SetActive(true);
        contadorCalles++;
        Calle.name= "calle" + contadorCalles;
        Calle.transform.parent = motorCarreteras.transform;

        GameObject piezAux = GameObject.Find("calle" +( contadorCalles-1));

        Calle.transform.position = new Vector3(transform.position.x,piezAux.GetComponent<Renderer>().bounds.size.y + piezAux.transform.position.y,piezAux.transform.position.z );


	}
    public void SpeedStop()
    {
        speed = 0;
    } 
    public void SpeedArcen()
    {
        speed = 5;
    } 
    public void SpeedCarretera()
    {
        speed = 15;
    }
    public void SpeedCocheMalo()
    {
        speed = 3;
    }
     public void FinalizarJuego()
    {
		SpeedStop();
	}

     
}
