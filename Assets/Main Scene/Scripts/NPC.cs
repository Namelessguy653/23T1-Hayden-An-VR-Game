using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    [SerializeField] GameObject correctCanvas;
    [SerializeField] GameObject nextNPC;
    [SerializeField] float spawnDelay = 4.95f;


    public void YesChoice()
    {
        correctCanvas.SetActive(true);
        Destroy(gameObject, 5f);
        Invoke("SpawnNextNPC", spawnDelay);
    }

    void SpawnNextNPC()
    {
        nextNPC.SetActive(true);
        // Set the Y rotation of the new object to 90 degrees
        nextNPC.transform.rotation = Quaternion.Euler(0, 90, 0);
    }
}
