using UnityEngine;
using System.Collections;

public class ClickableItem : MonoBehaviour {

    private SpriteManager.E_SPRITE id = SpriteManager.E_SPRITE.BOOK;

    public static bool itemClickedThisFrame = false;
    

	void OnMouseDown()
    {
        ItemInHand.instance.PutItemInHand(id);
        itemClickedThisFrame = true;
        Destroy(gameObject);
    }


    public void SetItemID(SpriteManager.E_SPRITE _id)
    {
        id = _id;
    }





}
