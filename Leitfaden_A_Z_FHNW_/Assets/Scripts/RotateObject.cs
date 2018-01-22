using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RotateObject : MonoBehaviour { 
    //Variable zur manuellen rotations geschwindigkeits Angabe
    public float speed;

	
	void Start () {
		
	}
	
	// Update wird 1x pro Frame aufgerufen
	void Update () {
        Rotate();
    }
    void Rotate() {
        //Rotation Vector3.Richtung * Time.deltaTime(Konstante die zur Rotation verwendet wird) * Manuelle geschwindigkeit
        transform.Rotate(Vector3.up* Time.deltaTime*speed);
    }
}
