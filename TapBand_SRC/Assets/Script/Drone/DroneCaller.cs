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
        deltaTime = Random.Range(2, 4);




        StartCoroutine(waitSomeSeconds());

        //Instantiate(Drone, transform.position, transform.rotation);
    }
	

    IEnumerator waitSomeSeconds()
    {
        while(true)
        {
                yield return new WaitForSeconds(deltaTime);
                //print("Folytatom");
                //yield return new WaitForSeconds(3);
                Drone.SetActive(true);
                yield return new WaitForSeconds(5);

        }

        //yield return new WaitForSeconds(deltaTime);
        //print("Folytatom");
        //yield return new WaitForSeconds(3);
        //Drone.SetActive(true);
        //gameObject.SetActive(true);
        //Application.Quit();
    }
	// Update is called once per frame
	void Update () {
	
	}
}
