using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Queen : MonoBehaviour
{

    public GameObject[] tumores;
    float moveSpeed = 3.0f;

    // Start is called before the first frame update
    void Start()
    {
        tumores = GameObject.FindGameObjectsWithTag("Tumor");
    }

    // Update is called once per frame
    void Update()
    {
        tumores = GameObject.FindGameObjectsWithTag("Tumor");

        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(tumores[0].transform.position - transform.position), 3 * Time.deltaTime);

        transform.position += transform.forward * moveSpeed * Time.deltaTime;

        tumores = GameObject.FindGameObjectsWithTag("Tumor");

        //Dont work correctly
        if (tumores == null || tumores.Length == 0)
        {
            Destroy(gameObject);
        }

    }

}
