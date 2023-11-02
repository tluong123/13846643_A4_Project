using UnityEngine;

public class AspectRatioHandler : MonoBehaviour
{
    [SerializeField] private GameObject sixteenByNineElements;
    [SerializeField] private GameObject fourByThreeElements;

    void Start()
    {
        float screenAspect = (float)Screen.width / (float)Screen.height;

        if (Mathf.Approximately(screenAspect, 16.0f / 9.0f))
        {
            sixteenByNineElements.SetActive(true);
            fourByThreeElements.SetActive(false);
        }
        else if (Mathf.Approximately(screenAspect, 4.0f / 3.0f))
        {
            sixteenByNineElements.SetActive(false);
            fourByThreeElements.SetActive(true);
        }
        else
        {
            // Handle other aspect ratios or provide fallback UI elements.
        }
    }
}