using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float timer;
    public int newtarget;
    public UnityEngine.AI.NavMeshAgent nav;
    public Vector3 target;
    public GameObject WhiteSmoke;
    public AudioClip waka;
    private bool nothingDetected = true;
    private int nBusqueda;

    // Start is called before the first frame update
    void Start()
    {
        nav = gameObject.GetComponent<UnityEngine.AI.NavMeshAgent>();
        nBusqueda = 0;
        nothingDetected = true;
        WhiteSmoke.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (nothingDetected) {
            if (timer >= newtarget)
            {
                newTarget();
                timer = 0;
            }
        }
        else
        {
            if (timer >= newtarget)
            {
                inspectField();
                timer = 0;
            }
        }
    }

    // When a nanobot encounter a malicious cell, call the others and destroy the malicious cell.
    private void OnTriggerEnter(Collider other)
    {
        WhiteSmoke.SetActive(true);
        nothingDetected = false;
        gameObject.SendMessage("callToTumor");
        AudioSource.PlayClipAtPoint(waka, transform.position);
        Destroy(other.gameObject);
    }

    //Search Randomly
    void newTarget()
    {
        Vector3 searchRandom = transform.position + Quaternion.Euler(0, Random.Range(0, 360), 0) * (transform.forward * Random.Range(0,10)) ;
        nav.SetDestination(searchRandom);
    }

    // When the malicious cell has been destroyed, it will dance around it, calling other agents and looking for malicious cells.
    void inspectField()
    {
        Vector3 dancing = transform.position + Quaternion.Euler(0, Random.Range(0, 360), 0) * (transform.forward * Random.Range(0, 2));

        gameObject.SendMessage("callToTumor");

        nBusqueda += 1;
        if (nBusqueda == 3)
        {
            nothingDetected = true;
            WhiteSmoke.SetActive(false);
            nBusqueda = 0;
        }
        nav.SetDestination(dancing);
    }

    //Function to call others nanobot to a determinate position
    void callToTumor()
    {
        Collider[] hitColliders = Physics.OverlapSphere(gameObject.transform.position, 20f);
        int i = 0;
        while (i < hitColliders.Length)
        {
            if (hitColliders[i].tag == "Nano")
            {
                target = transform.position;
                hitColliders[i].gameObject.GetComponent<UnityEngine.AI.NavMeshAgent>().SetDestination(target);               
            }
        i++;
        }
    }
}
