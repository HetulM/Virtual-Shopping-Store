using UnityEngine;

public class shop : MonoBehaviour
{
  [Header("List of Items sold")]
  [SerializeField] private Clothes[] shopItem;

  [Header("Referenced")]
  [SerializeField] private Transform clothingContainer;
  [SerializeField] private GameObject shopItemPrefab;

  private void Start()
  {
    PopulateShop();
  }

  private void PopulateShop()
  {
    for (int i = 0; i < shopItem.Length; i++)
    {
      GameObject itemObject = Instantiate(shopItemPrefab, clothingContainer);
    }
  }
}

