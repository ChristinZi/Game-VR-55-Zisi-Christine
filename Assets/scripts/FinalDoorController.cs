using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FinalDoorController : MonoBehaviour //Με αυτό το script ανοίγει η τελευταία πόρτα
{
    [SerializeField] public GameObject yellowKey = null;   // είναι τρεις μεταβλητές για τους τρείς triggers που βρίσκοται στα δοχεία
    [SerializeField] public GameObject whiteKey = null;
    [SerializeField] public GameObject purpleKey = null;
    [SerializeField] private GameObject lastDoor = null; // η πόρτα που θα ανοίξει
    [SerializeField] public GameObject winText;  //το μήνυμα νίκης
    public AudioSource audioSource; 
    public AudioClip metalDoorOpen;  //το ηχητικό

    void Update()   //συνεχώς ελέγχεται
    {
        bool yellowSet = yellowKey.GetComponent<ChalicController>().isSet;  //παίρνουμε τη σημαία από κάθε δοχείο 
        bool whiteSet = whiteKey.GetComponent<ChalicController>().isSet;
        bool purpleSet = purpleKey.GetComponent<ChalicController>().isSet;
        if ((yellowSet) && (whiteSet) && (purpleSet))   //όταν είναι και οι τρείς true
        {
            lastDoor.SetActive(false);  //φεύγει η τελευταία πόρτα και ο παίκτης μπορεί να βγεί
            winText.SetActive(true);  // ενεργοποιείται το μήνυμα νίκης
            audioSource.PlayOneShot(metalDoorOpen); //παίζει το ηχητικό 
        }
    }
}
