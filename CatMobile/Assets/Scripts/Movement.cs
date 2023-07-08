using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] Rigidbody2D rg;
    [SerializeField] Transform myTransform;
    Camera mainCamera;
    Vector2 screenBounds;
    [SerializeField] float movementSpeed = 1000f;

    [SerializeField] float walkProbability = 0.0001f;

    void Start()
    {
        rg = GetComponent<Rigidbody2D>();
        mainCamera = Camera.main;
        screenBounds = GetScreenBounds();
    }

    void Update()
    {
        ClampPosition();

	if (Random.value < walkProbability){

        Vector2 randomDirection = Random.insideUnitCircle.normalized;
        Vector2 velocity = randomDirection * movementSpeed * Time.deltaTime;
        rg.velocity = velocity;
	}
    }

    void ClampPosition()
    {
        float clampedX = Mathf.Clamp(myTransform.position.x, -screenBounds.x, screenBounds.x);
        float clampedY = Mathf.Clamp(myTransform.position.y, -screenBounds.y, screenBounds.y);
        Vector2 clampedPosition = new Vector2(clampedX, clampedY);
        myTransform.position = clampedPosition;
    }

    Vector2 GetScreenBounds()
    {
        float orthographicHeight = mainCamera.orthographicSize;
        float orthographicWidth = orthographicHeight * mainCamera.aspect;

        float maxScreenX = orthographicWidth - (myTransform.localScale.x / 2f);
        float maxScreenY = orthographicHeight - (myTransform.localScale.y / 2f);

        return new Vector2(maxScreenX, maxScreenY);
    }
}

