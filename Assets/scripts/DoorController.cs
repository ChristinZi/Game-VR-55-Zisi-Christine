using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour //Με αυτό το script κλείνει η πρώτη πόρτα
{
    [SerializeField] private Animator myDoor = null;  //ο animator της πόρτας που θα κλείσει
    public AudioSource audioSource; 
    public AudioClip metalDoorClose;   //το ηχητικό


    void Start()   //μόλις ξεκινάει το παιχνίδι
    {
        myDoor.Play("DoorClose", 0, 0.0f);   //παίζει το animation
        audioSource.PlayOneShot(metalDoorClose);    //και το ηχητικό
    }
}
