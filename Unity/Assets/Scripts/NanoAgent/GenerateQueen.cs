using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateQueen : MonoBehaviour
{
    public GameObject nanoagent;
    public int numberofQueens;
    public Transform inyeccion;

    // start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < numberofQueens; i++)
        {
            GameObject nanoAgentIns = (GameObject)Instantiate(nanoagent, inyeccion.position, inyeccion.rotation);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
