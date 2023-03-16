using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    [SerializeField] GameObject correctCanvas;
    [SerializeField] GameObject incorrectCanvas;

    [SerializeField] GameObject nextNPC;
    [SerializeField] float spawnDelay = 4.95f;

    [SerializeField] float disableTime = 5f; // Time in seconds to wait before disabling the object

    private bool enableWrong = false;


    private void Update()
    {
        if (enableWrong == true)
        {
            disableTime -= Time.deltaTime;
            if (disableTime <= 0)
            {
                disableTime = 5f;
                enableWrong = false;
                incorrectCanvas.SetActive(false);
                return;
            }
        }
    }
    public void YesChoice()
    {
        correctCanvas.SetActive(true);
        Destroy(gameObject, 5f);
        Invoke("SpawnNextNPC", spawnDelay);
    }

    public void NoChoice()
    {
        enableWrong = true;
        incorrectCanvas.SetActive(true);
    }

    void SpawnNextNPC()
    {
        nextNPC.SetActive(true);
        // Set the Y rotation of the new object to 90 degrees
        nextNPC.transform.rotation = Quaternion.Euler(0, 90, 0);
    }
}
