using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selections : MonoBehaviour
{
    private GameObject[] shipslist;
    private int index;

    private void Start()
    {
        shipslist = new GameObject[transform.childCount];
    

        for(int i = 0; i < transform.childCount; i++)
        {
            shipslist[i] = transform.GetChild(i).gameObject;
        }

        foreach(GameObject go in shipslist) 
        {

            go.SetActive(false);

        }
        if (shipslist[0])
        {
            shipslist[0].SetActive(true);
        }

    }


    public void Toggleleft()
    {

        shipslist[index].SetActive(false);
        index--;
        if(index < 0) 
        {
            index = shipslist.Length - 1;
        }
        shipslist[index].SetActive(true);
    }
    public void Toggleright()
    {
        shipslist[index].SetActive(false);
        index++;
        if (index == shipslist.Length)
        {
            index =0;
        }
        shipslist[index].SetActive(true);
    }
}
