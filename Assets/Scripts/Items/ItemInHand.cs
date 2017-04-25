using UnityEngine;
using System.Collections;

public class ItemInHand : MonoBehaviour {

    static public ItemInHand instance;

    public GameObject pref_fallingItem;
    public GameObject pref_fishTail;

    [HideInInspector]
    public SpriteManager.E_SPRITE itemInHand;
    

    private float mouseFollowSpeed = 0.9f;

    void Awake()
    {       
        instance = this;        
    }

    void Start()
    {
        itemInHand = SpriteManager.E_SPRITE.NONE;
    }


    void Update()
    {
        HandFollowsMouse();       
        if (Input.GetKeyDown(KeyCode.Mouse0) && itemInHand != SpriteManager.E_SPRITE.NONE && !ClickableItem.itemClickedThisFrame)
        {
            OnClick();
        }
        ClickableItem.itemClickedThisFrame = false;
    }



    public void OnClick()
    {
        CreateFallingObject(Camera.main.ScreenToWorldPoint(Input.mousePosition));
        RemoveItemFromHand();
    }

    public void PutItemInHand(SpriteManager.E_SPRITE _itemID)
    {
        itemInHand = _itemID;
        GetComponent<SpriteRenderer>().sprite = SpriteManager.GetSpritePair(_itemID).holdSprite;
    }
    public void RemoveItemFromHand()
    {
        GetComponent<SpriteRenderer>().sprite = null;
        itemInHand = SpriteManager.E_SPRITE.NONE;
    }
    public bool IsItemInHand()
    {
        return (itemInHand == SpriteManager.E_SPRITE.NONE) ? false : true;
    }
   


    private void HandFollowsMouse()
    {
        Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        gameObject.transform.position = pos;
    }

    
    private GameObject CreateFallingObject(Vector2 _pos)
    {            
        GameObject go = (GameObject)Instantiate(pref_fallingItem, _pos, Quaternion.identity);
        go.GetComponent<SpriteRenderer>().sprite = SpriteManager.GetSpritePair(itemInHand).holdSprite;
        go.AddComponent<BoxCollider2D>().isTrigger = true;        ;
        if (SpriteManager.GetSpritePair(itemInHand).type == Item.E_ITEM_TYPE.NORMAL)
            go.AddComponent<NormalItem>();
        if (SpriteManager.GetSpritePair(itemInHand).type == Item.E_ITEM_TYPE.WEARABLE)
            go.AddComponent<WearableItem>();
        if (SpriteManager.GetSpritePair(itemInHand).type == Item.E_ITEM_TYPE.EFFECT)
            go.AddComponent<EffectItem>();
        go.GetComponent<Item>().id = itemInHand;
        return go;
    }

    


}
