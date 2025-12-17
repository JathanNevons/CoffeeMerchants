using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicCoffee : MonoBehaviour, IInteractable
{
    public bool IsOpened { get; private set; }
    public string BasicCoffeeID { get; private set; }
    public GameObject itemprefab;
    public Sprite openedSprite;

   // Start is called before the first frame update
    void Start()
    {
        BasicCoffeeID ??= GlobalHelper.GenerateUniqueID(gameObject);
    }


    public bool CanInteract()
    {
        return !IsOpened;
    }

    public void Interact()
    {
        if (!CanInteract()) return;
    }
    private void OpenBasicCoffee()
    {
        //SetOpened

        //DropItem
    }

    public void SetOpened(bool opened)
    {
        IsOpened = opened;
        if (IsOpened)
        {
            GetComponent<SpriteRenderer>().sprite = openedSprite;
        }
    }
}
