using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class btnBehavior : MonoBehaviour, IVirtualButtonEventHandler {

    //Set up Variables for Objects to use
    public GameObject vbBtnObj1;
    public GameObject sphere;
    

	void Start () {
        //Sucht nach einem Button der den Namen SphereButton hat und übergibt diesen einem event handler
        vbBtnObj1 = GameObject.Find("SphereButton");
        vbBtnObj1.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        //Sucht nach der Kugel und setzt sie auf unsichtbar
        sphere = GameObject.Find("Sphere");
        sphere.SetActive(false);
    }

    //Methode auf Buttons
    public void OnButtonPressed( VirtualButtonBehaviour vb) {
        //wenn finger auf button regristriert wird setzt boolean auf true 
        sphere.SetActive(true);

    }
    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        //Setzt das objekt auf invisible wenn der finger nicht mehr auf dem Button ist
        sphere.SetActive(false);
    }
    // Update is called once per frame
    void Update () {
		
	}
}
