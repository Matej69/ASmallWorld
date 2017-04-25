using UnityEngine;
using System.Collections;

public class FollowFish : MonoBehaviour {

    private float speed = 0.1f;

	void Update ()
    {
        HandleFishFollowing();
    }


    public void HandleFishFollowing()
    {
        transform.position = Vector2.Lerp(transform.position, FishExistance.instance.transform.position, speed * Time.deltaTime);
    }

    public void SetSpeed(float _amount)
    {
        speed = _amount;
    }

}
