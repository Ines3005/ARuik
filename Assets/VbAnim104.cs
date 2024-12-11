using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VbAnim104 : MonoBehaviour
{
    public GameObject classImage; // L'image de la classe
    public GameObject classText;  // Le texte associé

    // Start est appelé au début
    void Start()
    {
        // Cache l'image et le texte au début
        classImage.SetActive(false);
        classText.SetActive(false);
    }

    // Appelé lorsqu'un événement se produit (exemple : détection d'un marqueur)
    public void ShowClassInfo()
    {
        // Affiche l'image et le texte
        classImage.SetActive(true);
        classText.SetActive(true);

        Debug.Log("La classe 104 est affichée.");
    }

    // Méthode pour cacher les éléments si nécessaire
    public void HideClassInfo()
    {
        classImage.SetActive(false);
        classText.SetActive(false);

        Debug.Log("La classe 104 est cachée.");
    }
}

