using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouvement : MonoBehaviour
{
    private int saut = 0; // Compte le nombre de saut
    private int hauteur = 5; // initialisation de la hauteur maximal du saut réalisable
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.forward * 0.01f);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.back * 0.01f);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.up, -2);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(Vector3.up, 2);
        }
        if (Input.GetKey(KeyCode.Space) && saut<hauteur) // Afin de ne pas pouvoir sauter en continu, la variable hauteur va limiter le nombre de saut consécutifs et ainsi contrôler la hauteur du saut
        {
            transform.Translate(Vector3.up * 0.2f); // Pour réaliser un saut il faut réaliser une translation en fonction de l'axe des Y, celle-ci sera répéte plusieurs fois en fonction de la valeur de la variable 'hauteur'
            saut+=1;;   // Incrémentation de la variable 'saut' pour limiter la hauteur du saut et le rendre plus réaliste
        }
        if(transform.position.y <= 1) // Vérification de la position du personnage pour savoir si il est sur le sol et donc si on l'autorise à nouveau à réaliser un saut
        {
            saut=0; // Remise à 0, afin de lui permettre de sauter à nouveau
        }
        if (Input.GetKey(KeyCode.LeftShift)) // Utilisation de LeftShift afin de réaliser l'action de sprint avec la touche Shift
        {
            transform.Translate(Vector3.back * 0.02f); // Afin de réaliser un sprint, le simple fait de double la vitesse de déplacement par rapport à son déplacement via les flèches est suffissant (donc un passage de '0.01f' à '0.02f')
        }
    }
}
