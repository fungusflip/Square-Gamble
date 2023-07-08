using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MergeScript : MonoBehaviour
{
    [SerializeField] GameObject Rare;
    private void OnCollisionEnter(Collision other)
    {
        GameObject otherObject = other.gameObject;

        if (gameObject.CompareTag("Common") && otherObject.CompareTag("Common"))
        {
            GameObject instantiatedCommon = Instantiate(Rare, otherObject.transform.position, Quaternion.identity);
            // Additional code to modify or interact with the instantiated object "instantiatedCommon"
        }
    }

}
