using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clothes : MonoBehaviour
{
    private Animator animator;
    public string toolName;
    private static string tool ="";
    public string clothingName;
    private static string clothing = "";
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(toolName + " " + clothingName);
        animator = GetComponent<Animator>();

        ChangeTool();
        ChangeClothes();
        if (clothing.Length != 0 && tool.Length != 0)
        {
            OutfitPicker();
        }
        if (clothing.Length == 0)
        {
            ToolPicker();
        }
        if (tool.Length == 0)
        {
            ClothesPicker();
        }
        
    }

    private void ToolPicker()
    {
        switch (tool)
        {
            case "Kardas":
                animator.SetLayerWeight(1, 1);
                break;
            case "Kirvis":
                animator.SetLayerWeight(2, 1);
                break;
            case "Špaga":
                animator.SetLayerWeight(3, 1);
                break;
            case "Deglas":
                animator.SetLayerWeight(4, 1);
                break;
        }
    }

    private void ClothesPicker()
    {
        switch (clothing)
        {
            case "Pirato kepurė":
                animator.SetLayerWeight(1, 1);
                break;
            case "Mušk. kepurė":
                animator.SetLayerWeight(5, 1);
                break;
            case "Skarelė":
                animator.SetLayerWeight(9, 1);
                break;
            case "Perukas":
                animator.SetLayerWeight(13, 1);
                break;
        }
    }

    private void OutfitPicker()
    {
        switch (clothing)
        {
            case "Pirato kepurė":
                switch (tool)
                {
                    case "Kardas":
                        animator.SetLayerWeight(1, 1);
                        break;
                    case "Kirvis":
                        animator.SetLayerWeight(2, 1);
                        break;
                    case "Špaga":
                        animator.SetLayerWeight(3, 1);
                        break;
                    case "Deglas":
                        animator.SetLayerWeight(4, 1);
                        break;
                }
                break;
            case "Mušk. kepurė":
                switch (tool)
                {
                    case "Kardas":
                        animator.SetLayerWeight(5, 1);
                        break;
                    case "Kirvis":
                        animator.SetLayerWeight(6, 1);
                        break;
                    case "Špaga":
                        animator.SetLayerWeight(7, 1);
                        break;
                    case "Deglas":
                        animator.SetLayerWeight(8, 1);
                        break;
                }
                break;
            case "Skarelė":
                switch (tool)
                {
                    case "Kardas":
                        animator.SetLayerWeight(9, 1);
                        break;
                    case "Kirvis":
                        animator.SetLayerWeight(10, 1);
                        break;
                    case "Špaga":
                        animator.SetLayerWeight(11, 1);
                        break;
                    case "Deglas":
                        animator.SetLayerWeight(12, 1);
                        break;
                }
                break;
            case "Perukas":
                switch (tool)
                {
                    case "Kardas":
                        animator.SetLayerWeight(13, 1);
                        break;
                    case "Kirvis":
                        animator.SetLayerWeight(14, 1);
                        break;
                    case "Špaga":
                        animator.SetLayerWeight(15, 1);
                        break;
                    case "Deglas":
                        animator.SetLayerWeight(16, 1);
                        break;
                }
                break;
        }
    }

    private void ChangeTool()
    {
        if (toolName.Length != 0)
        {
            tool = toolName;
        }
    }

    private void ChangeClothes()
    {
        if (clothingName.Length != 0)
        {
            clothing = clothingName;
        }
    }
}
