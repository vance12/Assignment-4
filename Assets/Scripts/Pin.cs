using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class Pin : MonoBehaviour {

	private bool isPinned = false;

	private DateTime lastHit;
	private TimeSpan hitInterval;

	public float speed;
	public Rigidbody2D rb;

	void Update ()
	{
        if (Data.Instance.paused)
        {
			speed = 0f;
        }
        else
        {
			speed = 20f * Data.Instance.pinSpeed * Time.timeScale;
		}
		
		if (!isPinned)
			rb.MovePosition(rb.position + Vector2.up * speed * Time.deltaTime);
		hitInterval = DateTime.Now - lastHit;
	}

	void OnTriggerEnter2D (Collider2D col)
	{
		if (col.tag == "Rotator")
		{
			transform.SetParent(col.transform);
			Data.Instance.score++;
			isPinned = true;
		} else if (col.tag == "Pin")
		{
			if (Data.Instance.lives > 0 && hitInterval.Seconds > .1 && !isPinned)
            {
				this.isPinned = true;
				lastHit = DateTime.Now;
				Data.Instance.lives-=1;
				FindObjectOfType<GameManager>().EndGame();
			}
			if (Data.Instance.lives == 0)
            {
				SceneManager.LoadScene("End");
			}
			
		}
	}

}
