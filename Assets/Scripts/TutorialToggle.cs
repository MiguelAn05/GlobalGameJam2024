using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialToggle : MonoBehaviour
{
    public GameObject tutorialObject;
    public void tutorialToggle(bool isActive)
    {
        tutorialObject.SetActive(isActive);
    }
}
