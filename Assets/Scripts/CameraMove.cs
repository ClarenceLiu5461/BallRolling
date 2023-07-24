using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public Transform player;
    void Update()
    {
        transform.position = new Vector3(player.transform.position.x, player.transform.position.y + 10f, player.transform.position.z - 5f);
    }
}
