using UnityEngine;
using System.Collections;

public class PlayerProjectile : MonoBehaviour {

    public GameObject spawnPosObj;
    public GameObject bullet;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bullet, spawnPosObj.transform.position, Quaternion.identity);
            GetComponent<AudioSource>().Play();
        }
	}
}
