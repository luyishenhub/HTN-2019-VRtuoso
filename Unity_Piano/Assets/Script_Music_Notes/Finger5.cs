using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finger5 : MonoBehaviour
{
    
    public AudioSource C_Note;
    public AudioSource D_Note;
    public AudioSource E_Note;
    public AudioSource F_Note;
    public AudioSource G_Note;
    public AudioSource A_Note;
    public AudioSource B_Note;
    public AudioSource C1_Note;
    public AudioSource D1_Note;
    public AudioSource E1_Note;
    public AudioSource F1_Note;
    public AudioSource CS_Note;
    public AudioSource DS_Note;
    public AudioSource FS_Note;
    public AudioSource GS_Note;
    public AudioSource Bb_Note;
    public AudioSource CS1_Note;
    public AudioSource DS1_Note;
    
    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Cube_C")
        {
            C_Note.Play();
        } else if (col.gameObject.name == "Cube_D")
        {
            D_Note.Play();
        } else if (col.gameObject.name == "Cube_E")
        {
            E_Note.Play();
        } else if (col.gameObject.name == "Cube_F")
        {
            F_Note.Play();
        } else if (col.gameObject.name == "Cube_G")
        {
            G_Note.Play();
        } else if (col.gameObject.name == "Cube_A")
        {
            A_Note.Play();
        } else if (col.gameObject.name == "Cube_B")
        {
            B_Note.Play();
        } else if (col.gameObject.name == "Cube_C1")
        {
            C1_Note.Play();
        } else if (col.gameObject.name == "Cube_D1")
        {
            D1_Note.Play();
        } else if (col.gameObject.name == "Cube_E1")
        {
            E1_Note.Play();
        } else if (col.gameObject.name == "Cube_F1")
        {
            F1_Note.Play();
        } else if (col.gameObject.name == "Cube_CS")
        {
            CS_Note.Play();
        } else if (col.gameObject.name == "Cube_DS")
        {
            DS_Note.Play();
        } else if (col.gameObject.name == "Cube_FS")
        {
            FS_Note.Play();
        } else if (col.gameObject.name == "Cube_GS")
        {
            GS_Note.Play();
        } else if (col.gameObject.name == "Cube_Bb")
        {
            Bb_Note.Play();
        } else if (col.gameObject.name == "Cube_CS1")
        {
            CS1_Note.Play();
        } else if (col.gameObject.name == "Cube_DS1")
        {
            DS1_Note.Play();
        }
        
    }

}

