using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetActiveUI : MonoBehaviour
{
  // Start is called before the first frame update
  public GameObject startUiElement;
  public Button button;

  void Start()
  {
    startUiElement.SetActive(false);

    button.onClick.AddListener(() =>
    {
      startUiElement.SetActive(true);
    });
  }
}


