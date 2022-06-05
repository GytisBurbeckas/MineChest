using UnityEngine;

[CreateAssetMenu(fileName = "CollectablesDatabase", menuName = "Shopping/Collectables database")]
public class CollectablesDatabase : ScriptableObject
{
    public Collectable[] collectables;

    public int CollectablesCount
    {
        get { return collectables.Length; }
    }

    public Collectable GetCollectables(int index)
    {
        return collectables[index];
    }

    public void CollectCollectable(int index)
    {
        collectables[index].isCollected = true;
    }
}