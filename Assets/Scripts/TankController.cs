using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankController : MonoBehaviour
{
    GameObject TankShell;
    bool action = false;

    void Start()
    {
        TankShell = transform.Find("TankShell").gameObject;
        TankShell.SetActive(false);
    }

    void Update()
    {
        if (Input.GetMouseButton(0))
        { 
            Vector2 tapPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Collider2D collition2d = Physics2D.OverlapPoint(tapPoint);
            if(collition2d.gameObject == gameObject)
            {
                action = true;
            }
            if (action)
            {
                
            }
        }

        
    }
}
