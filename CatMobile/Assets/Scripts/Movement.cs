using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] Rigidbody2D rg;
    // Start is called before the first frame update
    void Start()
    {
        float RandomX = Random.Range(0, 1);
        float RandomY = Random.Range(0, 1);
        Rigidbody2D rg = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        int TickCheckWalk = Random.Range(0, 100);

        if (TickCheckWalk == 10){

            Rigidbody2D  rg = new Vector2D(RandomX * Time.deltaTime, RandomY * Time.deltaTime, 0);
        }

        
    }
}
