using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyX : MonoBehaviour
{
    public float speed;
    private Rigidbody enemyRb;
    private GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        Player = GameObject.Find("Player");
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 LookDirection = (Player.transform.position - transform.position).normalized;
        enemyRb.AddForce(LookDirection * speed * Time.deltaTime);
        
    }
}
