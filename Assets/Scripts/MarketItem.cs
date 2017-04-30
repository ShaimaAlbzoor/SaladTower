using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MarketItem : MonoBehaviour 
{
	public Toggle Status;
	public Image Icon;
	public Text Price;
	public Item Item;

	public void UpdateUI (Item item)
	{
		this.Item = item;
		Icon.sprite = item.Icon;
		Price.text = item.Price.ToString () + "$";
	}
}
