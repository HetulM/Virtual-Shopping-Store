using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideItem : MonoBehaviour
{
  public GameObject item;

  // Start is called before the first frame update
  void Start()
  {
    item.SetActive(false);
  }
}
