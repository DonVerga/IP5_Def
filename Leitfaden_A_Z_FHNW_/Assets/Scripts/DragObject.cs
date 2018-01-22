using UnityEngine;
using System.Collections;

public class DragObject : MonoBehaviour {

    Vector3 dist;
    float posX;
    float posY;

    //Methode die auf elemente angewandt werden kann
    void OnMouseDown()
    {
        //Distanz des objekt zur Kamera
        dist = Camera.main.WorldToScreenPoint(transform.position);
        //Berechnung der momentanen Possition der Maus/Finger x, y Achse zur Kamera
        posX = Input.mousePosition.x - dist.x;
        posY = Input.mousePosition.y - dist.y;
    }

    //Wenn Maus/Finger bewegt wird
    void OnMouseDrag()
    {
        //Berechnung der Verschiebung seit OnMouseDown()
        Vector3 curPos = new Vector3(Input.mousePosition.x - posX, Input.mousePosition.y - posY, dist.z);

        //Berechnung der Kamera Distanz zum Object für den Scaling effekt
        Vector3 worldPos = Camera.main.ScreenToWorldPoint(curPos); transform.position = worldPos;
    }
}