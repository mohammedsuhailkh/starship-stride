


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerFollow : MonoBehaviour
{
    private GameObject playerObject;

    void Awake()
    {
        playerObject = GameObject.FindWithTag("Player");
    }

    private void LateUpdate()
    {
        if (playerObject != null)
        {
            Transform playerTransform = playerObject.transform;
            Vector3 cameraPosition = transform.position;
            cameraPosition.x = Mathf.Max(cameraPosition.x, playerTransform.position.x);
            transform.position = cameraPosition;
        }
    }
}


