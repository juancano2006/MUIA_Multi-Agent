using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement3D : MonoBehaviour
{
    public float timer;
    public int newtarget;
    public AudioClip waka;
    private int numberLifes = 10;

    public GameObject myQueen;
    float moveSpeed = 3.0f;

    public float speed = 2.5f;

    // Start is called before the first frame update
    void Start()
    {
        myQueen = GameObject.Find("Queen");
    }

    // Update is called once per frame
    void Update()
    {
        if (!GameObject.Find("Queen"))
        {
            Destroy(this);
        }

        if (numberLifes == 0)
        {
            Destroy(this);
        }

        Collider[] hitColliders = Physics.OverlapSphere(gameObject.transform.position, 40f);
        int i = 0;
        while (i < hitColliders.Length)
        {
            if (hitColliders[i].tag == "Queen")
            {
                transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(hitColliders[i].transform.position - transform.position), 3 * Time.deltaTime + Random.Range(-100f, 10f));
                transform.position += transform.forward * moveSpeed * Time.deltaTime;
            }
            i++;
        }
    }

    // When a nanobot encounter a malicious cell, call the others and destroy the malicious cell.
    private void OnTriggerEnter(Collider other)
    {
        gameObject.SendMessage("callToTumor");
        AudioSource.PlayClipAtPoint(waka, transform.position);
        Destroy(other.gameObject);
        numberLifes -= 1;
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
                transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(hitColliders[i].transform.position - transform.position), 3 * Time.deltaTime + Random.Range(-100f, 10f));
                transform.position += transform.forward * moveSpeed * Time.deltaTime;
            }
        i++;
        }
    }
}
