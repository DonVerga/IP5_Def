using UnityEngine;
using System.Collections;

[RequireComponent(typeof(MeshRenderer))]

public class rotateController : MonoBehaviour
{

    #region ROTATE
    private float sensibility = 0.4f;
    private Vector3 actualMousePosition;
    private Vector3 newMousePosition;
    private Vector3 amountRotation = Vector3.zero;
    private bool alreadyRotating;


    #endregion

    void Update()
    {
        //falls Objekt Rotiert wird
        if (alreadyRotating)
        {
            // neue Mausposition nach actualMousePosition onMouseDown()
            newMousePosition = (Input.mousePosition - actualMousePosition);

            // berechnugn wieviel rotiert werden muss
            amountRotation.z = -(newMousePosition.x + newMousePosition.y) * sensibility;

            // Rotations transformation
            gameObject.transform.Rotate(amountRotation);

            // Neue Maus oder Finger possition
            actualMousePosition = Input.mousePosition;
        }
    }

    void OnMouseDown()
    {
        // wenn Mausgedrückt oder Finger auf dem Display ist
        alreadyRotating = true;

        // Speichert punkt der Maus oder Finger
        actualMousePosition = Input.mousePosition;
    }

    void OnMouseUp()
    {
        // Wenn Finger nicht auf Display oder Maus nicht gedrückt
        alreadyRotating = false;
    }

}