using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Basket : MonoBehaviour
{
  // Start is called before the first frame update
  public GameObject startUiElement;
  public Clothes item;
  public Text nameText;
  public Text priceText;

  private static Clothes temp;

  public static List<Clothes> basket = new List<Clothes>();

  void Start()
  {
    startUiElement.SetActive(false);
  }

  void OnMouseDown()
  {
    nameText.text = "- " + item.GetName() + "\n";
    priceText.text = "£" + item.GetPrice() + "\n\n";
    Debug.Log(item);
    startUiElement.SetActive(true);
    temp = item;
  }

  public static Clothes getItem()
  {
    Clothes new_item = temp;
    return new_item;
  }
}
