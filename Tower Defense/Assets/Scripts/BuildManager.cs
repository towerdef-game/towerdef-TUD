using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour
{
    public static BuildManager instance;


     void Awake()
    {
        if(instance != null)
        {
            Debug.LogError("More Than one buildManager");
            return;
        }

        instance = this;
    }

    public GameObject GunPrefab;
    public GameObject LaserPrefab;
    public GameObject MissilePrefab;

    public GameObject Buildeffect;

    private TurretBlueprint TurretBuild;

   // public void Start()
   // {
   //     TurretBuild = GunPrefab;
  //  }
    public bool CanBuild { get { return TurretBuild != null; } }
    public bool HasMoney { get { return stats.Money >= TurretBuild.cost; } }

    public void BuildTurrethere (Node node)
    {
        if(stats.Money < TurretBuild.cost)
        {           
            return;
        }
        stats.Money -= TurretBuild.cost;
        GameObject turret = (GameObject)Instantiate(TurretBuild.prefab, node.GetBuildPosition(), Quaternion.identity);
        node.turret = turret;
      //  GameObject effect = (GameObject)Instantiate(Buildeffect, node.GetBuildPosition(), Quaternion.identity);
       // Destroy(effect, 5f); get rid of this if we decide to add the particle effect on the turrets themselves
        Debug.Log("Turret Constructing" + stats.Money);
    }

    public void SelectTurretToBuild(TurretBlueprint turret)
    {
        TurretBuild = turret;
    }
}
