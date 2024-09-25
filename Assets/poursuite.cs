using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class poursuite : MonoBehaviour
{
    public Vector3 C;
    public Vector3 S;
    public float v;
    public GameObject cible;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        C = this.transform.position;
        S = cible.transform.position;
        Vector3 PersoCible = -(cible.transform.position - transform.position);
        if(PersoCible != Vector3.zero){
            Quaternion rotationCible = Quaternion.LookRotation(PersoCible);
            transform.rotation = Quaternion.Slerp(transform.rotation, rotationCible, Time.deltaTime * 5f);
        }
    }
}
