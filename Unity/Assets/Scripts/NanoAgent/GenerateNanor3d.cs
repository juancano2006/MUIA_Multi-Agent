using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateNano3d : MonoBehaviour
{

    public GameObject nanoagent;
    public int numberofagentsTotal;
    public Transform inyeccion;

    // start is called before the first frame update
    void Start()
    {
        for (int z = 0; z < numberofagentsTotal/3; ++z)
        {
            for (int x = 0; x < numberofagentsTotal / 3; ++x)
            {
                for (int y = 0; y < numberofagentsTotal / 3; ++y)
                {
                    Instantiate(nanoagent, new Vector3(inyeccion.position.x + x, inyeccion.position.y + y, inyeccion.position.z + z), Quaternion.identity);
                }
            }
        }
    }

    // update is called once per frame
    void Update()
    {
        
    }
}
