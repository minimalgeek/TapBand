using UnityEngine;
using System.Collections;

public class DroneCaller1 : MonoBehaviour {

    public GameObject Drone;
    public int DroneMaxInterval = 10;
    public int DroneMinDelay = 10;
    public int DroneMaxDelay = 30;
    int deltaTime;
    //int deltaTime = Random.Range(DroneMinDelay, DroneMaxDelay);

    // Use this for initialization
    void Start () {
        //print("Elindultam");

    }

    void Example()
    {
        InvokeRepeating("Setactive", 10, 10);
    }
    void Setactive()
    {
        Drone.SetActive(true);
    }

	void Update () {
	
	}
}

