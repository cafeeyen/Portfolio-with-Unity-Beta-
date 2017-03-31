using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;

    private Vector3 offset;
    private float X_CAMERA = 140, Y_CAMERA = 20;

	void Start ()
    {
        transform.position = new Vector3(player.transform.position.x + X_CAMERA, player.transform.position.y + Y_CAMERA, player.transform.position.z);
        offset = transform.position - player.transform.position;
	}

	void LateUpdate ()
    {
        if(player.transform.position.z >= 600 && player.transform.position.z  <= 750)
        {
            offset.x = X_CAMERA + (player.transform.position.z - 600) / 7.5f;
            offset.y = Y_CAMERA + (player.transform.position.z - 600) / 5f;
        }
        if (player.transform.position.z >= 1200 && player.transform.position.z <= 1300)
        {
            offset.x = X_CAMERA + 20 + (player.transform.position.z - 1200) / 1.2f;
            offset.y = Y_CAMERA + 30 +(player.transform.position.z - 1200) / 1.8f;
        }

        transform.position = player.transform.position + offset;
	}
}
