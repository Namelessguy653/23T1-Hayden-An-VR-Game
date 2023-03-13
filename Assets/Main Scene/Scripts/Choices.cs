using Oculus.Interaction;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Choices : MonoBehaviour
{
    [SerializeField] List<GameObject> objectsToDestroy;
    [SerializeField] NPC npc;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Yes"))
        {
            CorrectChoice();
            foreach (GameObject obj in objectsToDestroy)
            {
                if (other.gameObject == obj)
                {
                    // destroy all objects in the list
                    foreach (GameObject objToDestroy in objectsToDestroy)
                    {
                        Destroy(objToDestroy);
                    }
                    break;
                }
            }
        }
        else
        {
            WrongChoice();
        }
    }

    public void CorrectChoice()
    {
        Debug.Log("Yes");
        npc.YesChoice();
    }
    public void WrongChoice()
    {
        Debug.Log("No");
    }
}
