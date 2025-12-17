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
        OpenBasicCoffee();
    }
    private void OpenBasicCoffee()
    {
        SetOpened(true);
        //DropItem
        if (itemprefab)
        {
            GameObject droppedItem = Instantiate(itemprefab, transform.position + Vector3.down, Quaternion.identity);
        }
    }
    

    public void SetOpened(bool opened)
    {
        if (IsOpened = opened)
        {
            GetComponent<SpriteRenderer>().sprite = openedSprite;
        }
    }
}