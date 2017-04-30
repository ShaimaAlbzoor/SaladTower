using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class MarketPanel : MonoBehaviour 
{
	public ScrollRect ScrollView;
	public MarketItem MarketItem;
	public ShoppingCartPopup BuyPopup;
	public ItemsResources itemsResources;

	private List <Item> marketItemList;

	void Awake ()
	{
		this.gameObject.SetActive (false);
	}

	public void Show ()
	{
		ScrollView.verticalNormalizedPosition = 1;

		foreach (Item item in itemsResources.ItemsDic.Values) {
			MarketItem marketItem = Instantiate (MarketItem);
			marketItem.transform.SetParent (ScrollView.content.transform, false);
			marketItem.UpdateUI (item);
		}

		this.gameObject.SetActive (true);
	}

	public void Buy ()
	{
		marketItemList = new List<Item> ();

		for (int i = 0; i < ScrollView.content.childCount; i++) {
			MarketItem marketItem = ScrollView.content.transform.GetChild (i).gameObject.GetComponent <MarketItem> ();
			if (marketItem.Status.isOn) {				
				marketItemList.Add (marketItem.Item);
				marketItem.Status.isOn = false;
			}
		}
		BuyPopup.Show (marketItemList);
	}

	public void Close ()
	{
		for (int i = 0; i < ScrollView.content.childCount; i++) {
			Destroy (ScrollView.content.transform.GetChild (i).gameObject);
		}
		this.gameObject.SetActive (false);
	}
}
