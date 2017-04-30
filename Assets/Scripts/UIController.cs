using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class UIController : MonoBehaviour
{
	public MarketPanel MarketPanel;
	public GameObject ShoppingCartPopup;
	public GameObject TakeTourPopup;
	public GameObject AboutUsPanel;

	void Awake ()
	{
		AboutUsPanel.SetActive (false);
		TakeTourPopup.SetActive (false);
	}

	public void ShowMarketPanel ()
	{
		MarketPanel.Show ();
	}

	public void ShowTowerTripScene ()
	{
		TakeTourPopup.SetActive (true);
	}

	public void HideTowerTripScene ()
	{
		TakeTourPopup.SetActive (false);
	}

	public void ShowAboutUsPanel ()
	{
		AboutUsPanel.SetActive (true);
	}

	public void HideAboutUsPanel ()
	{
		AboutUsPanel.SetActive (false);
	}
}
