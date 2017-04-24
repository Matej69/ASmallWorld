using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SpriteManager : MonoBehaviour {

    private static SpriteManager instance;

    public enum E_SPRITE
    {
        RUBBER_DUCK,
        COOKIE,
        BILLIAR_BALL,
        EYE_BALL,
        BOOK,
        BANANA,
        ARROW,
        UNDERPANTS,
        FISH_SKULL,
        MONEY,
        DIAMOND,
        BRICK,
        SALT,
        FISH_FOOD,

        HAT,
        CHAIN,
        GLASSES,
        RING,

        PAPER,      //EYES CRAZY
        MUSHROOM,   //SHADER
        POOP,       //SHADER
        FEMALE_FISH,
        OTTO,
        MILK,       //SHADER
        MEAT,
        KNIFE,      //TAIL CUT OFF
        COFFEE,     //SPEED
        BEER        //SHADER
    }

    [System.Serializable]
    public struct ItemSpritePair
    {
        public E_SPRITE id;
        public Item.E_ITEM_TYPE type;
        public Sprite holdSprite;
        public Sprite notHoldSprite; //can be released or on fish....
    }
    public List<ItemSpritePair> itemSprites; 
        

    
    void Awake()
    {
        instance = this;
    }

    static public ItemSpritePair GetSpritePair(E_SPRITE _spriteID)
    {
        foreach (ItemSpritePair pair in instance.itemSprites)
            if (pair.id == _spriteID)
                return pair;
        Debug.LogError("can not return sprite pair for SPRITE_ID = " + _spriteID);
        return instance.itemSprites[0];
    }



}
