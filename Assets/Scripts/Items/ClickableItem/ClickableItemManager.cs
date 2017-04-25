using UnityEngine;
using System.Collections;

public class ClickableItemManager : MonoBehaviour {

    public GameObject pref_clickableItem;

    GameObject itemToPickup = null;
    Timer timer_nextItem;

    void Start()
    {
        timer_nextItem = new Timer(1);
    }

    void Update()
    {
        HandleItemsSpawn();
    }




    void HandleItemsSpawn()
    {
        timer_nextItem.Tick(Time.deltaTime);
        if(itemToPickup == null && timer_nextItem.IsFinished())
        {
            SpriteManager.E_SPRITE randID = (SpriteManager.E_SPRITE)Random.Range(0, (int)SpriteManager.E_SPRITE.NONE);
            SpawnItem(randID);

            timer_nextItem.startTime = 8;
            timer_nextItem.Reset();
        }
    }

    void SpawnItem(SpriteManager.E_SPRITE _id)
    {
        itemToPickup = (GameObject)Instantiate(pref_clickableItem, transform.position, Quaternion.identity);
        itemToPickup.GetComponent<SpriteRenderer>().sprite = SpriteManager.GetSpritePair(_id).holdSprite;
        itemToPickup.AddComponent<BoxCollider2D>();
        itemToPickup.GetComponent<ClickableItem>().SetItemID(_id);                                                           
    }




}
