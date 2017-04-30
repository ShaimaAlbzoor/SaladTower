using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ShoppingCartItem : MonoBehaviour 
{
	public Image Icon;
	public Text Price;
	public InputField Input;

	private int price;

	public void UpdateUI (Item item)
	{
		Icon.sprite = item.Icon;
		Price.text = item.Price.ToString () + "$";
		price = item.Price;
	}

	public void OnValueChanged ()
	{
		int input = int.Parse (Input.text);
		if (input < 1) {
			input = 1;
		} else if (input > 12) {
			input = 12;
		}
		Price.text = (input * price).ToString () + "$";
	}

	public void Remove ()
	{
		Destroy (this.gameObject);
	}
}
