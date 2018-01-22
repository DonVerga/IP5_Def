
using UnityEngine;
using System.Collections;

public class Scaling : MonoBehaviour {
	
	
	public float initialFingersDistance;
	public Vector3 initialScale;
	public static Transform ScaleTransform;
	
	
	void  Update (){
		int fingersOnScreen = 0;
		
		foreach(Touch touch in Input.touches) {
            //Finger Zählen auf dem Display
            fingersOnScreen++; 
			
			//Abfrage ob zwei finger auf dem Display sind
			if(fingersOnScreen == 2){

                //Abfrage der initialen Finger Distanz Input-touches[0] = 1 Finger, Input-touches[1] = 2. Finger
                if (touch.phase == TouchPhase.Began){
					initialFingersDistance = Vector2.Distance(Input.touches[0].position, Input.touches[1].position);

                    // Momentane Skalierung
					initialScale = ScaleTransform.localScale;
				}
				else{
                    //Neue Distanz der Finger angeben
					float currentFingersDistance = Vector2.Distance(Input.touches[0].position, Input.touches[1].position);

                    //Wieviel Skalierung im Verhältniss  Momentane Position/ 1. Berürung 
                    float scaleFactor = currentFingersDistance / initialFingersDistance;
					
					//transform.localScale = initialScale * scaleFactor;
					ScaleTransform.localScale = initialScale * scaleFactor; 
				}
			}
		}
	}
	
}