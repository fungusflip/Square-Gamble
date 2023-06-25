using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] Rigidbody2D rg;
    [SerializeField] Transform myTransform;
    Camera mainCamera;
    Vector2 screenBounds;

    void Start()
    {
        rg = GetComponent<Rigidbody2D>();
        mainCamera = Camera.main;
        screenBounds = GetScreenBounds();
    }

    void Update()
    {
        float clampedX = Mathf.Clamp(myTransform.position.x, -screenBounds.x, screenBounds.x);
        float clampedY = Mathf.Clamp(myTransform.position.y, -screenBounds.y, screenBounds.y);
        Vector2 clampedPosition = new Vector2(clampedX, clampedY);
        myTransform.position = clampedPosition;

        int tickCheckWalk = Random.Range(0, 10000);
        float randomX = Random.Range(-100f, 100f);
        float randomY = Random.Range(-100f, 100f);

        if (tickCheckWalk == 1)
        {
            Vector2 randomVector = new Vector2(randomX * Time.deltaTime, randomY * Time.deltaTime);
            rg.velocity = randomVector;
        }
    }

    Vector2 GetScreenBounds()
    {
        float orthographicHeight = mainCamera.orthographicSize;
        float orthographicWidth = orthographicHeight * mainCamera.aspect;

        float maxScreenX = orthographicWidth - myTransform.localScale.x / 2f;
        float maxScreenY = orthographicHeight - myTransform.localScale.y / 2f;

        return new Vector2(maxScreenX, maxScreenY);
    }
}
