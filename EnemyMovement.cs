using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour {

    private int speed = 5;
    private int direction = 1;
    private int moveState = 0;
    private float timer = 0.0f;

    private bool justSwitched = false;

	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update ()
    {
	    if(moveState == 0)
        {
            MoveLeftAndRight();
        }
        if(moveState == 1)
        {
            MoveDown();
        }
	}

    private void MoveLeftAndRight()
    {
        transform.Translate(Vector3.right * speed * direction * Time.deltaTime);
        justSwitched = false;
        GetComponent<AudioSource>().Play();
        Debug.Log("Moving");

    }

    private void MoveDown()
    {
            transform.Translate(Vector3.down * speed * Time.deltaTime);
            timer += Time.deltaTime;
            if(timer > 0.1f)
            {
            SwitchDirection();
            
            }
        GetComponent<AudioSource>().Play();
        Debug.Log("Going Down.");

    }

    public void HitAWall()
    {
        if(moveState == 0 && !justSwitched)
        {
            moveState = 1;
        }
    }

    private void SwitchDirection()
    {
        direction *= -1;
        timer = 0;
        justSwitched = true;
        moveState = 0;
    }
}
