using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTimeTracker : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < GameObject.FindGameObjectsWithTag("TimeTracker").Length; i++)
        {
            Destroy(GameObject.FindGameObjectWithTag("TimeTracker"));
        }
    }
}
