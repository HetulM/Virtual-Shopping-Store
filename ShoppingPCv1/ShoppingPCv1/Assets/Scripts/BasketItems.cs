using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Basket", menuName = "Basket")]
public class BasketItems : ScriptableObject
{
  public new string name;
  public float price;

  //   public float GetPrice()
  //   {
  //     return price;
  //   }
}
