using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClothingInfo : MonoBehaviour

{

  private List<Clothes> basketItems = new List<Clothes>();

  public Text basketText;
  public Text basketPrice;

  private float total;


  // Start is called before the first frame update
  public void Start()
  {
    basketItems.AddRange(AddItemToBasket.getBasket());

    basketText.text = "";
    total = 0;
    for (int i = 0; i < basketItems.Count; i++)
    {
      basketText.text += "- " + basketItems[i].GetName() + "\n";
      total += basketItems[i].GetPrice();
    }

    basketPrice.text = "£" + total.ToString();
    Debug.Log(basketItems.Count);
  }
}
