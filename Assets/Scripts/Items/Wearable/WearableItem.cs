using UnityEngine;
using System.Collections;

public class WearableItem : Item {


    public override void OnWaterTouched()
    {
        GetComponent<ItemPhysics>().isInWater = true;
        GetComponent<ItemPhysics>().ReduceMovementByFactor(8);
        GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0.65f);
    }

    public override void OnBottomTouched()
    {
        GetComponent<ItemPhysics>().SetState(ItemPhysics.E_STATE.FOLLOWING);
        GetComponent<ItemPhysics>().SetMobility(false);
        //CALL GUI TEXT FOR FISH
    }

    public override void OnFishTouched()
    {
        ChangeFishSprite();
        Destroy(gameObject);
    }

    private void ChangeFishSprite()
    {
        switch(id)
        {
            case SpriteManager.E_SPRITE.HAT     :   FishExistance.instance.GetComponent<FishSprite>().SetSprite(FishSprite.E_FISH_SPRITE.HAT); break;
            case SpriteManager.E_SPRITE.GLASSES: FishExistance.instance.GetComponent<FishSprite>().SetSprite(FishSprite.E_FISH_SPRITE.GLASSES); break;
            case SpriteManager.E_SPRITE.CHAIN: FishExistance.instance.GetComponent<FishSprite>().SetSprite(FishSprite.E_FISH_SPRITE.CHAIN); break;
            case SpriteManager.E_SPRITE.RING: FishExistance.instance.GetComponent<FishSprite>().SetSprite(FishSprite.E_FISH_SPRITE.RING); break;
        }
    }

}
