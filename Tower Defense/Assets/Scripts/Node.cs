using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Node : MonoBehaviour
{

    public Color hoverColor;
    public Color notEnoughmoney;
    public Vector3 positionOffset;

   [Header("Optional")]
    public GameObject turret;

    private Renderer Rend;

    private Color StartColor;

    BuildManager BuildManager;
    // Start is called before the first frame update
    void Start()
    {
        Rend = GetComponent<Renderer>();
        StartColor = Rend.material.color;

        BuildManager = BuildManager.instance;
    }
    public Vector3 GetBuildPosition()
    {
        return transform.position + positionOffset;
    }

     void OnMouseDown()
    {
        if (!BuildManager.CanBuild)
            return;

        if(turret != null)
        {
            Debug.Log("Can't build there - TODO: Display on screen");
            return;
        }

        BuildManager.BuildTurrethere(this);
    }

    void OnMouseEnter()
    {
        if (EventSystem.current.IsPointerOverGameObject())
            return;

        if (!BuildManager.CanBuild)
            return;

        if (BuildManager.HasMoney)
        {
            Rend.material.color = hoverColor;
        }
        else
        {
            Rend.material.color = notEnoughmoney;
        }
    }

    public void OnMouseExit()
    {
        
        Rend.material.color = StartColor;
    }
}
