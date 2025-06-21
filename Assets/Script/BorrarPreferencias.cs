using UnityEngine;

public class BorrarPreferencias : MonoBehaviour
{
	void Awake()
	{
		PlayerPrefs.DeleteAll();
	}
}
