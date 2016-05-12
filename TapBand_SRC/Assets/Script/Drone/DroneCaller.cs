using UnityEngine;
using System.Collections;

public class DroneCaller : MonoBehaviour {

    public GameObject Drone;
    public int DroneMaxInterval = 10;
    public int DroneMinDelay = 10;
    public int DroneMaxDelay = 30;
    int deltaTime;
    //int deltaTime = Random.Range(DroneMinDelay, DroneMaxDelay);

    // Use this for initialization
    void Start () {
        print("Elindultam");
        deltaTime = Random.Range(3, 7);
        StartCoroutine(waitSomeSeconds());
    }
	

    IEnumerator waitSomeSeconds()
    {
        yield return new WaitForSeconds(deltaTime);
        print("Folytatom");
        yield return new WaitForSeconds(3);
        yield return 0;
        //Application.Quit();
    }
	// Update is called once per frame
	void Update () {
	
	}
}
