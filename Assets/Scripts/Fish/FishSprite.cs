using UnityEngine;
using System.Collections;

public class FishSprite : MonoBehaviour {
   

    public SpriteRenderer spriteRend;
    FishController controller;

	// Use this for initialization
	void Start ()
    {
        controller = GetComponent<FishController>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        UpdateSpriteDir();
    }





    void UpdateSpriteDir()
    {
        if (controller.GetDir() == FishController.E_DIR.LEFT)
            transform.localScale = new Vector2(Mathf.Abs(transform.localScale.x), transform.localScale.y);
        else
            transform.localScale = new Vector2(-Mathf.Abs(transform.localScale.x), transform.localScale.y);


    }

}
