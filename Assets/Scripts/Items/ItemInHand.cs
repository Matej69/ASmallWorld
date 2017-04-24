using UnityEngine;
using System.Collections;

public class ItemInHand : MonoBehaviour {

    public GameObject pref_fallingItem;

    SpriteManager.E_SPRITE id;

    private float mouseFollowSpeed = 0.9f;

    void Update()
    {
        SetItemID(SpriteManager.E_SPRITE.FEMALE_FISH);
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            OnClick();
        }
    }



    public void OnClick()
    {
        CreateFallingObject(Camera.main.ScreenToWorldPoint(Input.mousePosition));
    }


    
    private GameObject CreateFallingObject(Vector2 _pos)
    {            
        GameObject go = (GameObject)Instantiate(pref_fallingItem, _pos, Quaternion.identity);
        go.GetComponent<SpriteRenderer>().sprite = SpriteManager.GetSpritePair(id).holdSprite;
        go.AddComponent<BoxCollider2D>().isTrigger = true;        ;
        if (SpriteManager.GetSpritePair(id).type == Item.E_ITEM_TYPE.NORMAL)
            go.AddComponent<NormalItem>();
        if (SpriteManager.GetSpritePair(id).type == Item.E_ITEM_TYPE.WEARABLE)
            go.AddComponent<WearableItem>();
        if (SpriteManager.GetSpritePair(id).type == Item.E_ITEM_TYPE.EFFECT)
            go.AddComponent<EffectItem>();
        go.GetComponent<Item>().id = id;
        return go;
    }

    public void SetItemID(SpriteManager.E_SPRITE _id)
    {
        id = _id;
    }
    


}
