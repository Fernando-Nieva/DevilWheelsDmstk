using UnityEngine;

public class LimiteCarreteras : MonoBehaviour
{
	public MotorCarreteras motorCarreterasScript;

	public void OnTriggerEnter2D(Collider2D cInfo)
	{
		Debug.Log("Algo entró al trigger: " + cInfo.gameObject.name);

		if (cInfo.gameObject.CompareTag("LimiteCalles"))
		{
			Debug.Log("¡El objeto tiene el tag 'LimiteCalles'!");

			if (cInfo.transform.parent != null)
			{
				Debug.Log("Destruyendo el objeto padre: " + cInfo.transform.parent.name);
				Destroy(cInfo.transform.parent.gameObject);
			}
			else
			{
				Debug.LogWarning("El objeto con tag 'LimiteCalles' NO tiene padre.");
				Destroy(cInfo.gameObject); // Como emergencia, destruye el propio objeto
			}

			motorCarreterasScript.CreaCalles();
		}
		else
		{
			Debug.Log("El objeto NO tiene el tag 'LimiteCalles', su tag es: " + cInfo.gameObject.tag);
		}
	}
}
