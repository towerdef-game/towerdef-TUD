using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemy_Ai : MonoBehaviour
{
    public GameObject Base;
    public int health = 2;
    public int dropmoney = 50;
   
    // Start is called before the first frame update
    void Start()
    {
        Base = GameObject.FindGameObjectWithTag("Base");
    }

    public void damagetaken(int amount)
    {
        health -= amount;
        if(health <= 0)
        {
            Die();
        }

    }

     void Die()
    {
        Destroy(gameObject);

        stats.Money += dropmoney;
       
    }
    // Update is called once per frame
    void Update()
    {
        GetComponent<NavMeshAgent>().destination = Base.transform.position;

    }
    void OnTriggerEnter(Collider other)
    {
       if (other.tag == "Base")
       {
           stats.Health--;
       Destroy(gameObject);
      }
   }
}
