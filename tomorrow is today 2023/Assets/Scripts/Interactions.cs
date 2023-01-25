using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Interactions : MonoBehaviour
{
    public bool isOpen;
    public GameObject objet;
    public void OpenLetter()
    {
        isOpen = !isOpen;
        Debug.Log("Letter is now open");
        objet.SetActive(isOpen);
    }

    public void OpenDoor()
    {
        isOpen = false;
        Debug.Log("La porte est ouverte");
        objet.SetActive(isOpen);
    }

    public void PassageAuNiveauSuivant()
    {
        Debug.Log("Tu peux passer a l'étape suivante");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}