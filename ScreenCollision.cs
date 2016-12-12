using UnityEngine;
using System.Collections;

public class ScreenCollision : MonoBehaviour {

    public EnemyMovement moverScript;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Camera.main.WorldToViewportPoint(this.transform.position).x > 0.95f || Camera.main.WorldToViewportPoint(this.transform.position).x < 0.05f)
        {
            moverScript.HitAWall();
            Debug.Log("Hit a Wall.");
        }
    }
}
