using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChalicController : MonoBehaviour  //Με αυτό το script δεχόμαστε την σωστή πέτρα σε κάθε δοχείο
{
    [SerializeField] ParticleSystem fire = null;  // το particle system Που θα ενεργοποιηθεί μόλις ενωθεί το ζεύγος πέτρα-δοχείο
    [SerializeField] private string StoneTag = null;  // Εδώ μπήκε tag για την αναγνώριση της σωστής πέτρας γιατί δώσαμε τη δυνατοτητα να είναι πολλές
    public bool isSet = false;  // σημαία αν επιτεύχθηκε  
    public AudioSource audioSource;  
    public AudioClip fireStarts;  //το ηχητικό

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(StoneTag))     //όταν γίνει trigger από σωστή πέτρα
        {
            fire.Play();                      //να ανοίξει το αντίστοιχο particle system
            isSet = true;                   // να πάρει η σημαία τιμή true
            audioSource.PlayOneShot(fireStarts);      //να παίξει το ηχητικό
        }
    }  
}
