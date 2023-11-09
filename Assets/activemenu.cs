using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activemenu : MonoBehaviour
{
    public bool change;
    public GameObject mainship;

    // Update is called once per frame
    void Update()
    {
        
    }
    public void close()
    {
        mainship.gameObject.GetComponent<Rotatable>().Allowed=true;
        change = true;
        this.gameObject.SetActive(false);
       
    }
}
