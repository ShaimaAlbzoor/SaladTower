using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Loading : MonoBehaviour 
{
	void Awake ()
	{
		SceneManager.LoadScene (1);
	}
}
