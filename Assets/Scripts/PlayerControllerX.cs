using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    private Rigidbody playerRb;
    public float jumpforce;
    public float speed = 5.0f;
    float forwardInput;
    float horizontalInput;
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        //player movement
        forwardInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);

        if (Input.GetKeyDown(KeyCode.Space))
        {
           playerRb.AddForce(Vector3.up * jumpforce, ForceMode.Impulse);
        }

        
    }

    void OnCollisionEnter()
    {
    if (collision.gameObject.CompareTag("Powerup"))
    {
        
    }
    }
}
