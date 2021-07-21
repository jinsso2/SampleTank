using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankController : MonoBehaviour
{
    public GameObject TankShell;
    Rigidbody2D rigid2D;
    bool action = false;

    void Start()
    {
        TankShell = transform.Find("TankShell").gameObject;
        TankShell.SetActive(false);
        rigid2D = GetComponent<Rigidbody2D>();
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
            // ≈ ≈© ¿Ãµø
            if (action)
            {
                rigid2D.AddForce(new Vector2(30, 0));
            }
            else
            {
                if(Input.GetMouseButtonUp(0) && action)
                {
                        TankShell.SetActive(true);
                        
                }
            }
        }

        
    }
}
