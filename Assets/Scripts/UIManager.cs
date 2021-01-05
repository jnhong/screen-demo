using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{

    public int currentScreenIndex = 0;

    private void Start()
    {
        currentScreenIndex = 0;
        int numScreens = gameObject.transform.childCount;
        if (numScreens < 1) return;
        gameObject.transform.GetChild(0).gameObject.SetActive(true);

        for (int i = 1; i < numScreens; ++i)
        {
            gameObject.transform.GetChild(i).gameObject.SetActive(true);
        }
    }

    public void GoToNextScreen ()
    {
        int numScreens = gameObject.transform.childCount;
        if (numScreens < 1) return;

        GameObject current = gameObject.transform.GetChild(currentScreenIndex).gameObject;
        currentScreenIndex = (currentScreenIndex + 1) % numScreens;
        Debug.Log("Current Screen is now: " + currentScreenIndex);
        GameObject next = gameObject.transform.GetChild(currentScreenIndex).gameObject;
        current.SetActive(false);
        next.SetActive(true);
    }
}
