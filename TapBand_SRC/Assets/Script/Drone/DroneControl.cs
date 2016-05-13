using UnityEngine;
using System.Collections;

public class DroneControl : MonoBehaviour {
    //public GameObject Drone;
    float timer;
    //float t = 0;
    //public float speed = 1.0f;
    //float dt = Time.deltaTime;

    Vector3[] keys = {
        new Vector3 (0, 0, 0),
        new Vector3 (-3.3f, 6, 0),
        new Vector3 (3.3f, 6, 0),
        new Vector3 (-3.3f, 1.3f, 0),
        new Vector3 (3.3f, 1.3f, 0)
    };

    Vector3 startPos;
    Vector3 startPos2;
    Vector3 zeroPos;
    Vector3 firstPos;
    //Vector3 secondPos;
    //Vector3 thirdPos;
    //Vector3 fourthPos;

    void Start()
    {
        MoveToStartPosition();
    }

    void MoveToStartPosition()
    {
        timer = Time.time;
        startPos = transform.position;
        zeroPos = new Vector3(0, 0, 0);
        //firstPos = new Vector3(-3.3f, 6, 0);
        //secondPos = new Vector3(3.3f, 6, 0);
        //thirdPos = new Vector3(-3.3f, 1.3f, 0);
        //fourthPos = new Vector3(3.3f, 1.3f, 0);
    }

    void Update()
    {
        if (Time.time - timer > 1)
        {
            MoveToStartPosition();
        }
        transform.position = Vector3.Lerp(startPos, zeroPos, Time.time - timer);
        //Drone.SetActive(false);

    }
    void OnMouseDown()
    {
        //Destroy(gameObject);
        //this.gameObject.SetActive(false);
        startPos2 = transform.position;
        transform.position = Vector3.Lerp(startPos2, startPos, Time.time - timer);
        this.gameObject.SetActive(false);
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
                    this.gameObject.SetActive(false);

                }
            }
        }
    }

}
