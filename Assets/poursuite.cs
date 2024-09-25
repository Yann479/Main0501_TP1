using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class poursuite : MonoBehaviour
{
    public Vector3 C; // Position du 'chat'
    public Vector3 S; // Position de la 'souris'
    public float v;
    public GameObject cible;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        C = this.transform.position; // Mettre à jour la position du 'chat'
        S = cible.transform.position; // Mettre à jour la position de la 'souris'
        Vector3 PersoCible = -(cible.transform.position - transform.position); // Inversion de la position pour orienter le personnage 'chat' dans la direction du personnage 'souris' (et non qu'il lui tourne le dos)
        if(PersoCible != Vector3.zero){ // vérification de l'emplacement du personnage 'souris' par rapport à l'orientation du pesonnage 'chat' pour savoir si il faut réaliser une modification
            transform.rotation = Quaternion.LookRotation(PersoCible); // Modification de la rotation du personnage 'chat' pour faire face au personnage 'souris'
        }
    }
}
