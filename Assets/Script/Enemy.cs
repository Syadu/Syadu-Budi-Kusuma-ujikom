using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private float enemySpeed = 2f;
    private float enemyHealth = 100f;
    private float enemyPoint;
    
    // Start is called before the first frame update
    void Start()
    {
        switch (enemyHealth)
        {
            case 0:
                enemyPoint = 200;
                break;
            case 1:
                enemyPoint = 100;
                break;
            case 2:
                enemyPoint = 200;
                break;
            case 3:
                enemyPoint = 300;
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        MoveEnemy();
    }

    public void MoveEnemy()
    {
        Vector3 move = new Vector3(0, 0, enemySpeed * Time.deltaTime);
        gameObject.transform.position -= move;
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.CompareTag("Wall"))
        {
            Destroy(gameObject);
        }

        if (other.collider.CompareTag("Bullet"))
        {
            enemyHealth -= 25;
        }
    }
}
