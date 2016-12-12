using UnityEngine;
using System.Collections;

public class InvaderProjectile : MonoBehaviour {

    public GameObject spawnPosObj;
    public GameObject bullet;
    public float shotTimer = 0.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        shotTimer += Time.deltaTime;
        if(shotTimer > 1.5)
        {
            Instantiate(bullet, spawnPosObj.transform.position, Quaternion.identity);
            shotTimer = 0;
        }
	}
}
