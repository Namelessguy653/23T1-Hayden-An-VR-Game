using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    [SerializeField] GameObject correctCanvas;
    [SerializeField] GameObject nextNPC;
    [SerializeField] float spawnDelay = 4.5f;


    public void YesChoice()
    {
        correctCanvas.SetActive(true);
        Destroy(gameObject, 5f);
        Invoke("SpawnNextNPC", spawnDelay);
    }

    void SpawnNextNPC()
    {
        Instantiate(nextNPC, transform.position, Quaternion.identity);
    }
}
