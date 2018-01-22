using UnityEngine;
using System.Collections;

public class onClickScaling : MonoBehaviour {
	void OnMouseDown() {
        //Übergabe der Scaling Scripts zur neu Berechnung
		Scaling.ScaleTransform = this.transform;
	}
}