using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_Bb_Note : MonoBehaviour
{
    
    public AudioSource Bb_Note;
    
    private void OnMouseDown()
    {
        
        {
            Bb_Note.Play();
        }
        
    }

}
