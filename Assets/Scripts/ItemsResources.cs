using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class ItemsResources : MonoBehaviour
{
	public Dictionary <string, Item> ItemsDic;

	void Awake ()
	{
		ItemsDic = new Dictionary<string, Item> ();
		Item item = new Item (Resources.Load<Sprite> ("cucumber"), 2);
		ItemsDic.Add ("cucumber", item);
		item = new Item (Resources.Load<Sprite> ("lettuce"), 5);
		ItemsDic.Add ("lettuce", item);
		item = new Item (Resources.Load<Sprite> ("parsley"), 3);
		ItemsDic.Add ("parsley", item);
		item = new Item (Resources.Load<Sprite> ("prod-pepper"), 1);
		ItemsDic.Add ("prod-pepper", item);
		item = new Item (Resources.Load<Sprite> ("tomato"), 4);
		ItemsDic.Add ("tomato", item);
	}
}
