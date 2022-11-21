using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextSelectionResponse : MonoBehaviour, ISelectionResponse
{
    [SerializeField] private GameObject interactText;

    public void OnDeselect(Transform selection)
    {
        interactText.SetActive(false);
    }

    public void OnSelect(Transform selectino)
    {
        interactText.SetActive(true);
    }
}
