using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MouseOver : MonoBehaviour
{
    public Color startColor;    
    public Color mouseoverColor;
    public Color SelectColor;
   public bool mouseover = false;
    public GameObject mainship;
   
    public GameObject Menu;


    private void OnMouseEnter()
    {
        mouseover = true;
        if( Menu.activeSelf==false)
        {
            this.GetComponent<Renderer>().material.color = mouseoverColor;
        }
        

    }
    private void OnMouseDown()
    {
        Menu.gameObject.GetComponent<activemenu>().change = false;
        Menu.SetActive(true);
        this.GetComponent<Renderer>().material.color = SelectColor;
        mainship.gameObject.GetComponent<Rotatable>().Allowed = false;


    }

    public void OnMouseExit()
    {
        mouseover = false;
        if(Menu.gameObject.GetComponent<activemenu>().change) { this.GetComponent<Renderer>().material.color = startColor; }
       
    }
}