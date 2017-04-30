using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class ShoppingCartPopup : MonoBehaviour
{
	public ScrollRect ScrollView;
	public ShoppingCartItem CartItem;
	public Text TotalPrice;
	public OrderPopup OrderPopup;

	private int price;

	void Awake ()
	{
		this.gameObject.SetActive (false);
	}

	public void Show (List <Item> marketItemList)
	{
		ScrollView.verticalNormalizedPosition = 1;
		price = 0;

		foreach (Item item in marketItemList) {
			ShoppingCartItem cartItem = Instantiate (CartItem);
			cartItem.UpdateUI (item);
			cartItem.gameObject.transform.SetParent (ScrollView.content.transform, false);
			price += item.Price;
		}

		TotalPrice.text = price.ToString ();
		this.gameObject.SetActive (true);
	}

	public void Buy ()
	{
		OrderPopup.Show ();
		Close ();
	}

	public void Close ()
	{
		for (int i = 0; i < ScrollView.content.childCount; i++) {
			Destroy (ScrollView.content.transform.GetChild (i).gameObject);
		}
		this.gameObject.SetActive (false);
	}
}
