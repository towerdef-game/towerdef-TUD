using UnityEngine;

public class bullet : MonoBehaviour
{
    private Transform target;
    public float speed = 70f;
    public int damage = 1;

    public void aim(Transform _target)
    {
        target = _target;
    }
    // Update is called once per frame
    void Update()
    {
        if (target == null)
        {
            Destroy(gameObject);
            return;
        }

        Vector3 dir = target.position - transform.position;
        float distanceThisFrame = speed * Time.deltaTime;

        if (dir.magnitude <= distanceThisFrame)
        {
            HitTarget();
            return;
        }
        transform.Translate(dir.normalized * distanceThisFrame, Space.World);
        transform.LookAt(target);
    }
    void HitTarget()
    {
       Damage(target);
       Destroy(gameObject);
       
    }
    void Damage(Transform enemy)
    {
      enemy_Ai bear =  enemy.GetComponent<enemy_Ai>();
      
       if(bear != null)
        {
            bear.damagetaken(damage);
        }
    }
}
