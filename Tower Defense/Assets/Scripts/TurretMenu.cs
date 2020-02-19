using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TurretMenu : MonoBehaviour
{

    public bool toggle = false;
    public GameObject turretMenuShop;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void turnTurretMenuOf()
    {

        if (!toggle)
        {
            turretMenuShop.SetActive(true);
            toggle = true;

        }
        else
        {
            turretMenuShop.SetActive(false);
            toggle = false;
        }
    }
}
