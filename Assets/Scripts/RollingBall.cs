using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RollingBall : MonoBehaviour
{
    public Text progressUI;
    public GameObject gate;
    public Rigidbody rigid;
    public int cheeseCubeThreshold;
    public int cheeseCubeEaten = 0;
    public float speed;
    public float horizontal;
    public float vertical;
    
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        progressUI.text = "Cube Eaten¡G0\nCubes Remaining¡G" + cheeseCubeThreshold;
    }

    
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(horizontal, 0.0f, vertical);
        rigid.AddForce(direction*speed);
    }

    public void CheckThreshold()
    {
        progressUI.text = "Cubes Eaten¡G" + cheeseCubeEaten + "\nCubes Remaining¡G" + (cheeseCubeThreshold - cheeseCubeEaten);
        if (cheeseCubeEaten >= cheeseCubeThreshold)
        {
            gate.SetActive(false);
        }
    }
}
