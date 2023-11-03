using UnityEngine;

public class AspectRatioScaler : MonoBehaviour
{
    private Camera mainCamera;
    private float baseWidth16_9 = 16f;
    private float baseHeight16_9 = 9f;
    private float baseWidth4_3 = 4f;
    private float baseHeight4_3 = 3f;

    void Start()
    {
        mainCamera = Camera.main;

        // Calculate the screen's aspect ratio.
        float screenAspect = (float)Screen.width / Screen.height;

        // Calculate the desired aspect ratios.
        float targetAspect16_9 = baseWidth16_9 / baseHeight16_9;
        float targetAspect4_3 = baseWidth4_3 / baseHeight4_3;

        // Calculate the horizontal and vertical scaling factors.
        float scaleWidth = screenAspect / targetAspect16_9;
        float scaleHeight = 1f;

        if (screenAspect < targetAspect16_9)
        {
            // Use 16:9-based scaling if the screen is narrower.
            mainCamera.orthographicSize /= scaleWidth;

            // Adjust the positions and sizes of your game objects for 16:9 here.
        }
        else if (screenAspect > targetAspect4_3)
        {
            // Use 4:3-based scaling if the screen is wider.
            mainCamera.orthographicSize /= scaleHeight;

            // Adjust the positions and sizes of your game objects for 4:3 here.
        }
        else
        {
            // Screen is between 16:9 and 4:3, no need to scale the camera.

            // Adjust the positions and sizes of your game objects for other aspect ratios here.
        }
    }
}
	