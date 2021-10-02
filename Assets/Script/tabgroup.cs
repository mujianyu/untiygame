using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tabgroup : MonoBehaviour
{
    public List<tabButton> tabButtons;
    public Sprite tabIdle;
    public Sprite tabHover;
    public Sprite tabActive;
    public tabButton selecttabButton;
    public List<GameObject> swap;

    public void AddButton(tabButton button)
    {
        if (tabButtons == null)
        {
            tabButtons = new List<tabButton>();
        }
        tabButtons.Add(button);
    }

    public void OntabEnter(tabButton button)
    {
        RestTabs();
        if(selecttabButton==null||button!=selecttabButton)
        {
            button.backgroud.sprite = tabHover;
        }
        
    }
    public void OntabExit(tabButton button)
    {
        RestTabs();
    }
    public void OntabSelect(tabButton button)
    {
        selecttabButton = button;
        RestTabs();
        button.backgroud.sprite = tabActive;
        int index = button.transform.GetSiblingIndex()-1;
        for(int i=0;i<swap.Count;i++)
        {
            if (i == index)
            {
                swap[i].SetActive(true);
            }
            else
            {
                swap[i].SetActive(false);
            }
        }
    }
    public void RestTabs()
    {
        foreach(tabButton button in tabButtons)
        {
            if(selecttabButton!=null && button == selecttabButton) 
            { 
                continue; 
            }
            button.backgroud.sprite = tabIdle;
        }
    }

}
