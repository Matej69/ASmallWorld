using UnityEngine;
using System.Collections;

public class FreeAudioObject : MonoBehaviour {

    Timer timer_destruction;

	void Start ()
    {
        timer_destruction = new Timer(5f);
    }
	
	// Update is called once per frame
	void Update () {
        timer_destruction.Tick(Time.deltaTime);
        if (timer_destruction.IsFinished())
            Destroy(gameObject);	
	}
}
