using UnityEngine;
using System.Collections;

public class ItemPhysics : MonoBehaviour {

    [HideInInspector]
    public bool isInWater = false;
    [HideInInspector]
    public bool didTouchedBottom = false;
    [HideInInspector]
    public bool didTouchedSurface = false;
    [HideInInspector]
    public bool didMiddleTouched = false;

    void Update ()
    {        
        if (canMove && state == E_STATE.FALLING)
        {
            MoveTowardsMiddle(0.1f);
            velocity.y -= vertAcc;
            transform.Translate(velocity * Time.deltaTime);
        }
        else if(state == E_STATE.FOLLOWING)
        {
            FollowFish();
        }
	}



    //FALLING PROPERTIES
    private bool canMove = true;
    private float vertAcc = 0.1f;
    private Vector2 velocity = new Vector2(0, 0);

    public void SetMobility(bool _state)
    {
        canMove = _state;
    }

    public void ReduceMovementByFactor(float _fac)
    {
        velocity.y = velocity.y / _fac;
        vertAcc = vertAcc / _fac;
    }

    private void MoveTowardsMiddle(float _speed)
    {
        transform.position = Vector2.Lerp(transform.position, Aquarium.instance.ref_middlePoint.transform.position, _speed * Time.deltaTime);
    }



    //FOLLOWING PROPERTIES
    float followSpeed = 0.65f;

    public enum E_STATE
    {
        FALLING,
        FOLLOWING
    }
    private E_STATE state = E_STATE.FALLING;
    public void SetState(E_STATE _state)
    {
        state = _state;
    }

    public void FollowFish()
    {
        transform.position = Vector2.Lerp(transform.position, FishExistance.instance.transform.position, followSpeed * Time.deltaTime);
    }
    







}
