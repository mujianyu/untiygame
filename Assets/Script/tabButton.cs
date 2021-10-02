using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
[RequireComponent(typeof(Image))]
public class tabButton : MonoBehaviour,IPointerEnterHandler,IPointerClickHandler,IPointerExitHandler
{
    public tabgroup tabGroup;
    public Image backgroud;
    void Start()
    {
        backgroud = GetComponent<Image>();
        tabGroup.AddButton(this);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        tabGroup.OntabSelect(this);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        tabGroup.OntabEnter(this);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        tabGroup.OntabExit(this);
    }
}
