using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DestroyAfter()); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator DestroyAfter()
    {
        yield return new WaitForSeconds(3f);
        Destroy(gameObject);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.collider)
        {
            Destroy(gameObject);
        }
    }
}
