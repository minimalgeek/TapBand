using UnityEngine;
using System.Collections;

public class touchToDestroy : MonoBehaviour {
    public GameObject Drone;
    void OnMouseDown()
    {
        //Destroy(gameObject);
        Drone.SetActive(false);
    }
    void Toucher()
    {
        if (Input.touchCount > 0)
        {
            Debug.Log("Touch detected.");

            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log("Raycast hit " + hit.collider.name);

                if (hit.collider.gameObject.tag == "new")
                {
                    Debug.Log("The tag matches.");
                    //Destroy(gameObject);
                    Drone.SetActive(false);

                }
            }
        }
    }

}
