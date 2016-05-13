using UnityEngine;
using System.Collections;

public class DroneMover : MonoBehaviour {
    float timer;
    float t = 0;
    public float speed = 1.0f;
    //float dt = Time.deltaTime;

    Vector3[] keys = {
        new Vector3 (0, 0, 0),
        new Vector3 (-3.3f, 6, 0),
        new Vector3 (3.3f, 6, 0),
        new Vector3 (-3.3f, 1.3f, 0),
        new Vector3 (3.3f, 1.3f, 0)
    };

    Vector3 startPos;
    Vector3 zeroPos;
   // Vector3 firstPos;
    //Vector3 secondPos;
    //Vector3 thirdPos;
    //Vector3 fourthPos;

    void Start()
    {
        MoveToStartPosition();
    }

    void MoveToStartPosition()
    {
        //timer = Time.time;
        startPos = transform.position;
        //zeroPos = new Vector3(0, 0, 0);
        //firstPos = new Vector3(-3.3f, 6, 0);
        //secondPos = new Vector3(3.3f, 6, 0);
        //thirdPos = new Vector3(-3.3f, 1.3f, 0);
        //fourthPos = new Vector3(3.3f, 1.3f, 0);
    }

    void Update()
    {
        float dt = Time.deltaTime;
        if (speed < 0) speed = 0;
        t += speed * dt;
        if (Time.time - timer > 1)
        {
            MoveToStartPosition();
        }
        //transform.position = Vector3.Lerp(startPos, keys[0], Time.time - timer);
        transform.position = Vector3.Lerp(startPos, keys[0], speed*t);
        zeroPos = transform.position;
        System.Threading.Thread.Sleep(1500);
        droneFlyer();

        //transform.position = Vector3.Lerp(startPos, zeroPos, Time.time - timer);

    }
    void droneFlyer()
    {

        for (int i = 0; i < 7; i++)
        {
            int r = Random.Range(1, 4);
            //transform.position = Vector3.Lerp(zeroPos, keys[r], Time.time - timer);
            transform.position = Vector3.Lerp(zeroPos, keys[r], speed*t);
            zeroPos = transform.position;
            System.Threading.Thread.Sleep(1000);
            i += 1;
        }

    }
}
