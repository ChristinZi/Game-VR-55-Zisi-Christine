using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AnimateHandOnInput : MonoBehaviour  // Με αυτό το script πετυχαίνουμε το συγχρονισμό χεριών-animation

{
    public InputActionProperty pinchAnimationAction;  // το input pinch του χειριστηρίου
    public InputActionProperty gripAnimationAction; // το input grip του χειριστηρίου
    public Animator handAnimator;       //ο animator του μοντέλου χεριού 
    
    void Update()
    {
        float triggerValue = pinchAnimationAction.action.ReadValue<float>();  //διαβάζει την τρέχουσα τιμή 
        handAnimator.SetFloat("Trigger", triggerValue);                         //και καλεί τον αντίστοιχο animator
                                                                         //είναι float γιατί τα κουμπιά είναι αναλογικά με τιμές [0.0,1.0]                          
        float gripValue = gripAnimationAction.action.ReadValue<float>();
        handAnimator.SetFloat("Grip", gripValue);
    }

}
