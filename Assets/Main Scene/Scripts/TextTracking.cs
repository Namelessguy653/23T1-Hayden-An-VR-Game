using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextTracking : MonoBehaviour
{
    public Transform playerPOV;

    // Update is called once per frame
    void Update()
    {
        transform.position = playerPOV.position;
    }
}
