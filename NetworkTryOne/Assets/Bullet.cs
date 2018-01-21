using UnityEngine;
using System.Collections;


public class Bullet : MonoBehaviour
{

    private void OnCollisionEnter(Collision col)
    {
        var hit = col.gameObject;
        var health = hit.GetComponent<Health>();

        if(health != null)
        {
            health.TakeDamage(10);
        }

        Destroy(gameObject);
    }
}