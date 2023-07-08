using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag : MonoBehaviour
{
    private bool isDragging = false;
    private Vector3 offset;
    [SerializeField] GameObject Rare;
    
    void OnMouseDown()
    {
        isDragging = true;
        offset = gameObject.transform.position - GetMouseWorldPosition();
    }

    void OnMouseUp()
    {
        isDragging = false;
    }

    void Update()
    {
        if (isDragging)
        {
            Vector3 mousePos = GetMouseWorldPosition();
            transform.position = mousePos + offset;
        }
        Debug.Log(isDragging);
    }

    Vector3 GetMouseWorldPosition()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = -Camera.main.transform.position.z;
        return Camera.main.ScreenToWorldPoint(mousePosition);
    }

    private void OntriggerEnter2D(Collider2D other)
    {
        Debug.Log("Something Happened");
        GameObject otherObject = other.gameObject;

        if (gameObject.CompareTag("Common") && otherObject.CompareTag("Common"))
        {
            GameObject instantiatedCommon = Instantiate(Rare, otherObject.transform.position, Quaternion.identity);
            // Additional code to modify or interact with the instantiated object "instantiatedCommon"
        }
    }

}
