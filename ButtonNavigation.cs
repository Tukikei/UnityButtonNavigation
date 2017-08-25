using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class ButtonNavigation: MonoBehaviour
{
        
    public void VerticalButtonNavigationFix(List<GameObject> buttonList)
    {
        if (buttonList.Count() > 1)
        {
            Navigation firstButton = buttonList[0].GetComponent<Button>().navigation;
            firstButton.mode = Navigation.Mode.Explicit;
            firstButton.selectOnUp = buttonList[buttonList.Count() - 1].GetComponent<Button>();
            firstButton.selectOnDown = buttonList[1].GetComponent<Button>();
            buttonList[0].GetComponent<Button>().navigation = firstButton;

            Navigation lastButton = buttonList[buttonList.Count() - 1].GetComponent<Button>().navigation;
            lastButton.mode = Navigation.Mode.Explicit;
            lastButton.selectOnUp = buttonList[buttonList.Count() - 2].GetComponent<Button>();
            lastButton.selectOnDown = buttonList[0].GetComponent<Button>();
            buttonList[buttonList.Count() - 1].GetComponent<Button>().navigation = lastButton;
        }
    }

    public void HorizontalButtonNavigationFix(List<GameObject> buttonList)
    {
        if (buttonList.Count() > 1)
        {
            Navigation firstButton = buttonList[0].GetComponent<Button>().navigation;
            firstButton.mode = Navigation.Mode.Explicit;
            firstButton.selectOnLeft = buttonList[buttonList.Count() - 1].GetComponent<Button>();
            firstButton.selectOnRight = buttonList[1].GetComponent<Button>();
            buttonList[0].GetComponent<Button>().navigation = firstButton;

            Navigation lastButton = buttonList[buttonList.Count() - 1].GetComponent<Button>().navigation;
            lastButton.mode = Navigation.Mode.Explicit;
            lastButton.selectOnLeft = buttonList[buttonList.Count() - 2].GetComponent<Button>();
            lastButton.selectOnRight = buttonList[0].GetComponent<Button>();
            buttonList[buttonList.Count() - 1].GetComponent<Button>().navigation = lastButton;
        }
    }

}
