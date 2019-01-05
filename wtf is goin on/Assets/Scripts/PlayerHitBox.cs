using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class PlayerHitBox : MonoBehaviour
{
    public float damage = 20;

    public float despawnTime = .1f;

    private void Awake()
    {
        StartCoroutine(decay());
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        Enemy thing = collision.GetComponent<Enemy>();
        if (thing != null) thing.takeDamage(damage);
        Destroy(gameObject);
    }

    IEnumerator decay()
    {
        Debug.Log("kek");
        yield return new WaitForSeconds(despawnTime);
        Debug.Log("meep");
        Destroy(gameObject);
    }
}
