using UnityEngine;
using System.Collections;

public class OrderPopup : MonoBehaviour
{
	void Awake ()
	{
		this.gameObject.SetActive (false);
	}

	public void Show ()
	{
		this.gameObject.SetActive (true);
	}

	public void Order ()
	{
		Close ();	
	}

	public void Close ()
	{
		this.gameObject.SetActive (false);
	}
}
