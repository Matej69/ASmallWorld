using UnityEngine;
using System.Collections;

[RequireComponent(typeof(ItemPhysics))]
public class EffectItem : Item {


    public override void OnWaterTouched()
    {
        GetComponent<ItemPhysics>().isInWater = true;
        GetComponent<ItemPhysics>().ReduceMovementByFactor(8);
        GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0.80f);

        if (id == SpriteManager.E_SPRITE.OTTO)
        {
            GetComponent<ItemPhysics>().SetMobility(false);
            gameObject.AddComponent<FollowFish>().SetSpeed(Random.Range(0.1f, 0.65f));
        }
    }



    public override void OnMiddleTouched()
    {
        if (GetComponent<ItemPhysics>().didTouchedSurface)
        { 
            if (id == SpriteManager.E_SPRITE.FEMALE_FISH)
            {
                GetComponent<ItemPhysics>().SetMobility(false);
                gameObject.AddComponent<FishController>().boxCol = gameObject.GetComponent<BoxCollider2D>();
                gameObject.AddComponent<FishSprite>().spriteRend = GetComponent<SpriteRenderer>();
                GetComponent<FishController>().SetSpeeds(0.1f, 0.5f, 0.3f, 2f);
                GetComponent<FishController>().mask = 1 << LayerMask.NameToLayer("Aquarium");
            }
            if (id == SpriteManager.E_SPRITE.POOP)
            {
                ShaderManager.instance.ApplyMaterial(ShaderManager.E_MATERIAL_TYPE.POOP);
            }
            if (id == SpriteManager.E_SPRITE.MILK)
            {
                ShaderManager.instance.ApplyMaterial(ShaderManager.E_MATERIAL_TYPE.MILK);
            }
            if (id == SpriteManager.E_SPRITE.MUSHROOM)
            {
                ShaderManager.instance.ApplyMaterial(ShaderManager.E_MATERIAL_TYPE.MUSHROOM);
                AudioManager.instance.CreateAudioObject(AudioManager.E_AUDIO.MUSHROOM);
            }
            if (id == SpriteManager.E_SPRITE.BEER)
            {
                ShaderManager.instance.ApplyMaterial(ShaderManager.E_MATERIAL_TYPE.BEER);
                AudioManager.instance.CreateAudioObject(AudioManager.E_AUDIO.BEER);
            }
        }
    }        



    public override void OnBottomTouched()
    {
        if (GetComponent<ItemPhysics>().didTouchedSurface)
        {
            GetComponent<ItemPhysics>().SetMobility(false);

            if (id == SpriteManager.E_SPRITE.PAPER)
            {
                FishExistance.instance.GetComponent<FishSprite>().SetSprite(FishSprite.E_FISH_SPRITE.EYE_RED);
                Destroy(gameObject);
            }
            if (id == SpriteManager.E_SPRITE.COFFEE)
            {
                FishExistance.instance.GetComponent<FishController>().SetSpeeds(1.5f, 4.5f, 1f, 3f);
            }
            if (id == SpriteManager.E_SPRITE.MEAT)
            {
                FishExistance.instance.GetComponent<FishController>().SetSpeeds(0.1f, 0.25f, 1f, 3f);
            }
            if (id == SpriteManager.E_SPRITE.KNIFE)
            {
                AudioManager.instance.CreateAudioObject(AudioManager.E_AUDIO.CUT_OFF);
                FishExistance.instance.GetComponent<FishSprite>().SetSprite(FishSprite.E_FISH_SPRITE.TAIL_OFF);
                Instantiate(ItemInHand.instance.pref_fishTail, FishExistance.instance.transform.position, Quaternion.identity);
            }
        }
    }




}
