using UnityEngine;
using System.Collections;

public class Item  
{
	public Sprite Icon;
	public int Price;

	public Item (Sprite icon, int price)
	{
		this.Icon = icon;
		this.Price = price;
	}
}
