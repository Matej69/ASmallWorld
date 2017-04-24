using UnityEngine;
using System.Collections;

[RequireComponent(typeof(ItemPhysics))]
public class EffectItem : Item {


    public override void OnWaterTouched()
    {
        GetComponent<ItemPhysics>().isInWater = true;
        GetComponent<ItemPhysics>().ReduceMovementByFactor(8);
        GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0.65f);
    }

    public override void OnBottomTouched()
    {
        GetComponent<ItemPhysics>().SetMobility(false);
        //CALL GUI TEXT FOR FISH
    }




}
