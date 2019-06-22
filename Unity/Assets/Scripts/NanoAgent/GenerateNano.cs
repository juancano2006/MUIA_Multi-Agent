using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateNano : MonoBehaviour
{

    public GameObject nanoagent;
    public int numberofagents;
    public Transform inyeccion;

    // start is called before the first frame update
    void Start()
    {
        for(int i=0; i<numberofagents; i++)
        {
            GameObject nanoAgentIns = (GameObject)Instantiate(nanoagent, inyeccion.position, inyeccion.rotation);
        }  
    }

    // update is called once per frame
    void Update()
    {
        
    }
}
