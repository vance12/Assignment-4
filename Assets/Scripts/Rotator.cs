using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour {

    public float speed;

	void Update ()
	{
        if (Data.Instance.paused)
        {
			speed = 0f;
        }
        else
        {
             speed = 100f * Data.Instance.rotatorSpeed;
        }
		transform.Rotate(0f, 0f, speed * Time.deltaTime);
	}

}
