using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddItemToBasket : MonoBehaviour
{

  private Clothes item;
  public GameObject startUiElement;
  public Text basketText;
  public Text basketPrice;

  private float total;

  private static List<Clothes> basketItems = new List<Clothes>();

  // Start is called before the first frame update
  void Start()
  {
    startUiElement.SetActive(false);

    Button button = gameObject.GetComponent<Button>();
    button.onClick.AddListener(AddItem);
  }

  void AddItem()
  {
    Clothes item = Basket.getItem();
    basketItems.Add(item);
    setItem();

    basketPrice.text = "£" + total.ToString();
    Debug.Log(basketItems.Count);
    startUiElement.SetActive(true);
  }

  public void remove()
  {
    basketItems.RemoveAt(basketItems.Count - 1);
    setItem();
    basketPrice.text = "£" + total.ToString();
  }

  public void setItem()
  {
    basketText.text = "";
    total = 0;
    for (int i = 0; i < basketItems.Count; i++)
    {
      basketText.text += "- " + basketItems[i].GetName() + "\n";
      total += basketItems[i].GetPrice();
    }
  }

  public static List<Clothes> getBasket()
  {
    List<Clothes> current_basket = new List<Clothes>();
    current_basket.AddRange(basketItems);
    return current_basket;
  }
}
