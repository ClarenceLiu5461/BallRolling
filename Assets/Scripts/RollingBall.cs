using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollingBall : MonoBehaviour
{
    public Rigidbody rigid;
    public float speed;
    public float horizontal;
    public float vertical;
    
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(horizontal, 0.0f, vertical);
        rigid.AddForce(direction*speed);
    }
}