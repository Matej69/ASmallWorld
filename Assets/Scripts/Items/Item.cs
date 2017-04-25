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

    virtual public void OnWaterTouched() { }
    virtual public void OnMiddleTouched() { }
    virtual public void OnBottomTouched() { }
    virtual public void OnFishTouched() { }    
    

    void OnTriggerEnter2D(Collider2D col)
    {
        //Water touched
        if(col.tag == "AquariumSurface" && !GetComponent<ItemPhysics>().didTouchedSurface)
        {
            OnWaterTouched();
            GetComponent<ItemPhysics>().didTouchedSurface = true;
            Textbox.GetInstance().EnableMessageBox(ItemMessagesInfo.Instance().GetMessages(id));
            AudioManager.instance.CreateAudioObject(AudioManager.E_AUDIO.WATER_SPLASH);
        }
        //Water touched
        if (col.tag == "AquariumMiddle" && !GetComponent<ItemPhysics>().didMiddleTouched)
        {
            OnMiddleTouched();            
            GetComponent<ItemPhysics>().didMiddleTouched = true;           
        }
        //Water bottom touched
        if (col.tag == "AquariumBottom" && !GetComponent<ItemPhysics>().didTouchedBottom && GetComponent<ItemPhysics>().didMiddleTouched)
        {
                OnBottomTouched();
                GetComponent<ItemPhysics>().didTouchedBottom = true;
        }
        //Fish touched
        if (col.tag == "Fish" && GetComponent<ItemPhysics>().didTouchedSurface)
        {
            if(GetComponent<ItemPhysics>().isInWater)
                OnFishTouched();
        }
    }
    


}
