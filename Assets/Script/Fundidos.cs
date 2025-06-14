using UnityEngine;
using UnityEngine.UI;

public class Fundidos : MonoBehaviour
{


    public Image imagenFundido; // Asegúrate de asignar esta imagen en el Inspector
	void Start()
    {

        imagenFundido.CrossFadeAlpha(0, 0.5f, false); // Inicia con la imagen invisible

	}

  
}
