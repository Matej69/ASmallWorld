using UnityEngine;
using System.Collections;

public class FishController : MonoBehaviour {

    public enum E_DIR
    {
        LEFT,
        RIGHT
    }
    private enum E_AXIS
    {
        HOR,
        VERT
    }
    
    private int rayNum = 7;
    public LayerMask mask;
    
    public float minSpeed;
    public float maxSpeed;

    private Vector2 velocity;
    private Vector2 targetVelocity;

    public BoxCollider2D boxCol;
    private Bounds bounds;

    private Timer timer_changeDir;
    [SerializeField]
    private float minChangeDirTime;
    [SerializeField]
    private float maxChangeDirTime;


    void Start()
    {
        bounds = boxCol.bounds;
        //velocity = new Vector2(0,0);
        targetVelocity = velocity;
        timer_changeDir = new Timer(0f);
    }
    
	void Update()
    {
        bounds = boxCol.bounds;

        HandleRandomMovementChange();
        HandleMovement();
    }
    

    void HandleRandomMovementChange()
    {
        timer_changeDir.Tick(Time.deltaTime);
        if(timer_changeDir.IsFinished())
        {
            //speed = Random.Range(minSpeed, maxSpeed);
            int newDir = (Random.Range(0, 2) == 0) ? 1 : -1 ;
            SetDir(E_AXIS.HOR, newDir);
            targetVelocity = new Vector2(Random.Range(minSpeed, maxSpeed) * newDir * Time.deltaTime, Random.Range(minSpeed, maxSpeed) * newDir * Time.deltaTime);

            float newMovementTime = Random.Range(minChangeDirTime, maxChangeDirTime);
            timer_changeDir.SetStartTime(newMovementTime);
            timer_changeDir.Reset();
        }
    }

    void HandleMovement()
    {
        CastHorizontalRay();
        CastVerticalRay();
        
        ApplyMovement();
    }



    void CastHorizontalRay()
    {
        Vector2 startPoint =  (Mathf.Sign(velocity.x) < 0 ) ? (Vector2)bounds.min : ((Vector2)bounds.min + new Vector2(bounds.extents.x * 2, 0) );
        Vector2 rayDir = (Mathf.Sign(velocity.x) < 0) ? Vector2.left : Vector2.right;
        float rayLength = Mathf.Abs(velocity.x);

        float rayDist = (bounds.extents.y * 2) / (rayNum - 1);
        for(int i = 0; i < rayNum; ++i)
        {
            Vector2 nextStartPoint = new Vector2(startPoint.x, startPoint.y + rayDist * i);
            RaycastHit2D hitInfo = Physics2D.Raycast(nextStartPoint, rayDir, rayLength, mask);
            if (hitInfo)
            {
                ChangeDir(E_AXIS.HOR);
            }

            //Debug.DrawRay(nextStartPoint, rayDir * rayLength, Color.blue, Time.deltaTime);
        }        
    }

    void CastVerticalRay()
    {
        Vector2 startPoint = (Mathf.Sign(velocity.y) < 0) ? (Vector2)bounds.min : ((Vector2)bounds.min + new Vector2(0, bounds.extents.y * 2));
        Vector2 rayDir = (Mathf.Sign(velocity.y) < 0) ? Vector2.down : Vector2.up;
        float rayLength = Mathf.Abs(velocity.y);

        float rayDist = (bounds.extents.x * 2) / (rayNum - 1);
        for (int i = 0; i < rayNum; ++i)
        {
            Vector2 nextStartPoint = new Vector2(startPoint.x + rayDist * i, startPoint.y);
            RaycastHit2D hitInfo = Physics2D.Raycast(nextStartPoint, rayDir, rayLength, mask);
            if (hitInfo)
            {
                ChangeDir(E_AXIS.VERT);
            }

            //Debug.DrawRay(nextStartPoint, rayDir * rayLength, Color.blue, Time.deltaTime);
        }
    }



    public E_DIR GetDir()
    {
        return (velocity.x > 0) ? E_DIR.RIGHT : E_DIR.LEFT;
    }

    void ChangeDir(E_AXIS _axis)
    {
        if (_axis == E_AXIS.VERT)
        {
            velocity.y = -velocity.y;
            targetVelocity.y = -targetVelocity.y;
        }
        else
        {
            velocity.x = -velocity.x;
            targetVelocity.x = -targetVelocity.x;
        }
    }

    void SetDir(E_AXIS _axis, int _dir)
    {
        if (_axis == E_AXIS.HOR)
            velocity.x = (_dir == 1) ? Mathf.Abs(velocity.x) : -Mathf.Abs(velocity.x);
        else
            velocity.y = (_dir == 1) ? Mathf.Abs(velocity.y) : -Mathf.Abs(velocity.y);
    }

    public void SetSpeeds(float _minSpeed, float _maxSpeed, float _minResetTime, float _maxResetTime)
    {
        minSpeed = _minSpeed;
        maxSpeed = _maxSpeed;
        minChangeDirTime = _minResetTime;
        maxChangeDirTime = _maxResetTime;
    }





    void ApplyMovement()
    {
        velocity = Vector2.Lerp(velocity, targetVelocity, Time.deltaTime);
        transform.Translate(velocity);
    }













}
