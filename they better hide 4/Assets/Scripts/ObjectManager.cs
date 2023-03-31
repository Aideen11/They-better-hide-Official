using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectManager : MonoBehaviour
{
    public List<GameObject> objectsToFind;
    public GameObject objectToDeactivate;

    private int numObjectsFound;

    private void Start()
    {
        numObjectsFound = 0;
    }

    public void ObjectFound(GameObject obj)
    {
        if (objectsToFind.Contains(obj))
        {
            numObjectsFound++;

            if (numObjectsFound >= objectsToFind.Count)
            {
                objectToDeactivate.SetActive(false);
            }
        }
    }
}