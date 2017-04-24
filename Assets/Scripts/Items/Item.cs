using UnityEngine;
using System.Collections;

public class Item : MonoBehaviour {

    public enum E_ITEM_TYPE
    {
        NORMAL,
        EFFECT,
        WEARABLE
    }

    [HideInInspector]
    public SpriteManager.E_SPRITE id;
    /*
    public void OnClick()
    {        
        //SPAWN GO WITH SAME ID but pair.notHoldSprite
        GameObject go = (GameObject)Instantiate(pref_fallingItem, transform.position, Quaternion.identity);
        go.GetComponent<SpriteRenderer>().sprite = SpriteManager.GetSpritePair(id).notHoldSprite;
        //DESTROY ITEM IN HAND
        Destroy(gameObject);
    }
    */
    virtual public void OnWaterTouched() { }
    virtual public void OnBottomTouched() { }
    virtual public void OnFishTouched() { }
   
    
    void OnTriggerEnter2D(Collider2D col)
    {
        //Water touched
        if(col.tag == "AquariumSurface")
        {
            OnWaterTouched();
        }
        //Water bottom touched
        if (col.tag == "AquariumBottom")
        {
            if (GetComponent<ItemPhysics>().isInWater)
                OnBottomTouched();
        }
        //Fish touched
        if (col.tag == "Fish")
        {
            if(GetComponent<ItemPhysics>().isInWater)
                OnFishTouched();
        }
    }
    


}
