using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class btnBehavior : MonoBehaviour, IVirtualButtonEventHandler {

    public GameObject vbBtnObj1;
    public GameObject sphere;
    

	// Use this for initialization
	void Start () {
        vbBtnObj1 = GameObject.Find("SphereButton");
        vbBtnObj1.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        sphere = GameObject.Find("Sphere");
        sphere.SetActive(false);




    }
    public void OnButtonPressed( VirtualButtonBehaviour vb) {
        sphere.SetActive(true);

    }
    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        sphere.SetActive(false);
    }
    // Update is called once per frame
    void Update () {
		
	}
}
