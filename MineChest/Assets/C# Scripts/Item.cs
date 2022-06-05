using UnityEngine;

[System.Serializable]
public struct Item
{
    public enum Type
    {
        Tool,
        Clothing
    }
    public Sprite image;
    public string name;
    public int price;
    public Type type;

    public bool isPurchased;
}
