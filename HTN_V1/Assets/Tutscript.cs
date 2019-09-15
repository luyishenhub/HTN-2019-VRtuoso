using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;

public class Tutscript : MonoBehaviour {

    public float speed;
    public float amountToMove;

    SerialPort sp = new SerialPort("COM6", 9600);

    // Use this for initialization
    void Start () {
        sp.Open();
        sp.ReadTimeout = 1;
	}
	
	// Update is called once per frame
	void Update () {
        amountToMove = speed * Time.deltaTime;

        if (sp.IsOpen)
        {
            try
            {
                MoveObject(sp.ReadByte());
                print(sp.ReadByte());
            }
            catch(System.Exception)
            {
            }
        }
	}

    void MoveObject(int Direction)
    {
        if (Direction == 1)
        {
            transform.Translate(Vector3.left * amountToMove, Space.World);
        }
        if (Direction == 2)
        {
            transform.Translate(Vector3.right * amountToMove, Space.World);
        }
    }
}
