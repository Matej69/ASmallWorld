using UnityEngine;
using System.Collections;

[RequireComponent(typeof(ItemPhysics))]
public class NormalItem : Item
{

    public override void OnWaterTouched()
    {
        GetComponent<ItemPhysics>().isInWater = true;
        GetComponent<ItemPhysics>().ReduceMovementByFactor(8);
        GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0.80f);
    }

    public override void OnBottomTouched()
    {

        if (GetComponent<ItemPhysics>().didTouchedSurface)
        {
            GetComponent<ItemPhysics>().SetMobility(false);
            if (id == SpriteManager.E_SPRITE.KNIFE)
                AudioManager.instance.CreateAudioObject(AudioManager.E_AUDIO.CUT_OFF);
        }
        //CALL GUI TEXT FOR FISH
    }

   


}
