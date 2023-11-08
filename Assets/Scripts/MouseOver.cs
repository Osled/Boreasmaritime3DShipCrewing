using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseOver : MonoBehaviour
{
    public Color startColor;    
    public Color mouseoverColor;
   public bool mouseover = false;


    private void OnMouseEnter()
    {
        mouseover = true;
        this.GetComponent<Renderer>().material.color = mouseoverColor;
    }

    private void OnMouseExit()
    {
        mouseover = false;
        this.GetComponent<Renderer>().material.color= startColor;
    }
}