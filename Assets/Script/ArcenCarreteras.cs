using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    private MotorCarreteras motorCarreterasScript;

    private void Start()
    {
        GameObject motorCarreteras = GameObject.Find("MotorCarreteras");

        if (motorCarreteras == null)
        {
            Debug.LogError("No se encontró el objeto MotorCarreteras en la escena.");
            return;
        }

        motorCarreterasScript = motorCarreteras.GetComponent<MotorCarreteras>();

        if (motorCarreterasScript == null)
        {
            Debug.LogError("El componente MotorCarreteras no está presente en el objeto MotorCarreteras.");
        }
    }

    private void OnTriggerEnter2D(Collider2D cInfo)
    {
        if (cInfo.CompareTag("coche") && motorCarreterasScript != null)
        {
            motorCarreterasScript.SpeedArcen();
            CambiarPitchAudio(cInfo.gameObject, 1f);
            // Debug.Log("Coche ha entrado en el trigger de ArcenCarreteras");
        }
    }

    private void OnTriggerExit2D(Collider2D cInfo)
    {
        if (cInfo.CompareTag("coche") && motorCarreterasScript != null)
        {
            motorCarreterasScript.SpeedCarretera();
            CambiarPitchAudio(cInfo.gameObject, 1.6f);
            // Debug.Log("Coche ha salido del trigger de ArcenCarreteras");
        }
    }

    private void CambiarPitchAudio(GameObject coche, float nuevoPitch)
    {
        AudioSource audio = coche.GetComponent<AudioSource>();
        if (audio != null)
        {
            audio.pitch = nuevoPitch;
        }
        else
        {
            Debug.LogWarning($"El objeto {coche.name} no tiene un componente AudioSource.");
        }
    }
}
