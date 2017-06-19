using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tempo : MonoBehaviour {

	private float timer = 1;

	float oldTimer;
	bool isRunning = true;

	void Start ()
	{
		oldTimer = timer;
	}

	// Update is called once per frame
	void Update ()
	{
		if (isRunning)
		{
			timer += Time.deltaTime;
			GetComponent<Text>().text = Mathf.RoundToInt(timer).ToString() + " s";

			if (timer < 0)
				isRunning = false;
		}
	}
}
