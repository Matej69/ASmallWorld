using UnityEngine;
using System.Collections;

public class FishSprite : MonoBehaviour {

    public SpriteRenderer spriteRend;

    public SpriteRenderer ref_eye;
    public GameObject ref_chain;
    public GameObject ref_hat;
    public GameObject ref_glasses;
    public GameObject ref_ring;

    public Sprite redEye;
    public Sprite tailOff;

    public enum E_FISH_SPRITE
    {
        EYE_RED,
        CHAIN,
        HAT,
        GLASSES,
        TAIL_OFF,
        RING
    }



    
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



    public void SetSprite(E_FISH_SPRITE _sprite)
    {
        switch(_sprite)
        {
            case E_FISH_SPRITE.CHAIN    :   ref_chain.SetActive(true); break;
            case E_FISH_SPRITE.GLASSES  :   ref_glasses.SetActive(true); break;
            case E_FISH_SPRITE.HAT      :   ref_hat.SetActive(true); break;
            case E_FISH_SPRITE.RING     :   ref_ring.SetActive(true); break;
            case E_FISH_SPRITE.EYE_RED  :   ref_eye.sprite = redEye; break;
            case E_FISH_SPRITE.TAIL_OFF :   spriteRend.sprite = tailOff; break;
        }
    }


}
