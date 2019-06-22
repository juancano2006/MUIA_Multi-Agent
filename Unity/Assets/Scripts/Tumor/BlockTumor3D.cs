using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BlockTumor3D : MonoBehaviour
{

    public GameObject block;
    public int width = 12;
    public int lenght = 12;
    public int height = 12;
    public Transform plano;

    // Start is called before the first frame update
    void Start()
    {
        for (int z = 0; z < lenght; ++z)
        {
            for (int x = 0; x < width; ++x)
            {
                for (int y = 0; y < height; ++y)
                {
                    int aux = (int)Random.Range(0.0f + z, 1.0f + x);
                    if (aux <= 10)
                    {
                        Instantiate(block, new Vector3(plano.position.x + x, plano.position.y + y, plano.position.z + z), Quaternion.identity);
                    }
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
