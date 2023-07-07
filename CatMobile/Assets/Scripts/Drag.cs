using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag : MonoBehaviour
{
	private bool isDragging = false;
	private Vector3 offset;
    // Start is called before the first frame update
    void OnMouseDown()
    {
        isDragging = true;
	offset = gameObject.transform.position - GetMouseWorldPosition();
    }

    void OnMouseUp()
    {
	    isDragging = false;
    
    }

    // Update is called once per frame
    //
    void Update()
    {
	    if (isDragging)
	    {
		    Vector3 mousePos = GetMouseWorldPosition();
		    transform.position = mousePos + offset;
	    }
        
    }

    Vector3 GetMouseWorldPosition()
    {
	    Vector3 mousePosition = Input.mousePosition;
	    mousePosition.z = -Camera.main.transform.position.z;
	    return Camera.main.ScreenToWorldPoint(mousePosition);
    }
}
