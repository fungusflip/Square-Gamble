using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class Movement : MonoBehaviour
{
    [SerializeField] Rigidbody2D rg;
    [SerializeField] Transform transform;
    [SerializeField] PositionConstraint positionConstraint;

    // Start is called before the first frame update
    void Start()
    {
        Resolution currentResoultion = Screen.currentResoultion;
        rg = GetComponent<Rigidbody2D>();
        positionConstraint.translationOffset = Screen.currentResoultion;

    }

    // Update is called once per frame
    void Update()
    {
        int TickCheckWalk = Random.Range(0, 10000);
        float RandomX = Random.Range(-50f, 50f);
        float RandomY = Random.Range(-50f, 50f);

        if (TickCheckWalk == 1){

            Vector2 randomVector = new Vector2(RandomX*Time.deltaTime, RandomY*Time.deltaTime);
            rg.velocity = randomVector;
        }

        
    }
}
