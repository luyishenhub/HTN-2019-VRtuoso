using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_CS_Note : MonoBehaviour
{
    
    public AudioSource CS_Note;
    
    private void OnMouseDown()
    {
        
        {
            CS_Note.Play();
        }
        
    }

}
