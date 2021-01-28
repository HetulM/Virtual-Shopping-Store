using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Clothing Item", menuName = "Clothing Item")]
public class Clothes : ScriptableObject
{
  public new string name;
  public float price;

  public string GetName()
  {
    return name;
  }

  public float GetPrice()
  {
    return price;
  }
}
