using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InDoorController : MonoBehaviour//Με αυτό το script ανοίγει η πρώτη πόρτα
{
    [SerializeField] private Animator myDoor = null; //ο animator της πόρτας που θα ανοίξει
    [SerializeField] private GameObject CorrectKey = null;  // το σωστό κλειδί
    public AudioSource audioSource; 
    public AudioClip keyTurns;//ηχητικό
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Key"))           //όταν γίνει trigger από το σωστό κλειδί
        {
            audioSource.PlayOneShot(keyTurns);            //παίζει το ηχητικό
            myDoor.Play("DoorOpen", 0, 0.0f);     //παίζει το animation
            gameObject.SetActive(false);            //απενεργοποιείται ο trigger και το κλειδί
            CorrectKey.SetActive(false);
        }
    }
}
