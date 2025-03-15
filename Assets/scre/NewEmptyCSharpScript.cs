using UnityEngine;

public class TouchInteraction : MonoBehaviour
{
    void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.gameObject == gameObject)
                {
                    RotateOnClick rotateScript = hit.transform.GetComponent<RotateOnClick>();
                    if (rotateScript != null)
                    {
                        rotateScript.enabled = !rotateScript.enabled;
                    }
                }
            }
        }
    }
}
