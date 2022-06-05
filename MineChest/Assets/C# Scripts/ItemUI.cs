using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Events;

public class ItemUI : MonoBehaviour
{

    [Space(20f)]
    [SerializeField] Image itemImage;
    [SerializeField] TMP_Text itemNameText;
    [SerializeField] TMP_Text itemPriceText;
    [SerializeField] Button itemButton;
    [SerializeField] TMP_Text purchasedText;

    //--------------------------------------------------------------
    public void SetItemPosition(Vector2 pos)
    {
        GetComponent<RectTransform>().anchoredPosition += pos;
    }

    public void SetItemImage(Sprite sprite)
    {
        itemImage.sprite = sprite;
    }
    public Sprite GetItemImage()
    {
        return itemImage.sprite;
    }

    public void SetItemName(string name)
    {
        itemNameText.text = name;
    }

    public void SetItemPrice(int price)
    {
        itemPriceText.text = price.ToString();
    }

    public void SetItemAsPurchased()
    {
        itemButton.gameObject.SetActive(false);
        purchasedText.text = "Purchased";
    }

    public void OnItemPurchase(int itemIndex, UnityAction<int> action)
    {
        itemButton.onClick.RemoveAllListeners();
        itemButton.onClick.AddListener(() => action.Invoke(itemIndex));
    }
    public void OnItemEquip(int itemIndex, UnityAction<int> action)
    {
        itemButton.onClick.RemoveAllListeners();
        itemButton.onClick.AddListener(() => action.Invoke(itemIndex));
    }
}
