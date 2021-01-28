using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
  public GameObject Object;
  private GameObject[] Basket;
  void Start()
  {
    Object.SetActive(false);
  }
  // Update is called once per frame
  void Update()
  {

  }

  void OnTriggerEnter(Collider collision)
  {
    if (collision.gameObject.tag.Equals("Cube"))
    {
      Debug.Log("Collision");
      Destroy(collision.gameObject);
      Object.SetActive(true);
    }
  }
}
