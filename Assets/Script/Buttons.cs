using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour
{
    public PonyChange pony;

    [Header("Buttons")]
    public GameObject MainButtons;
    public GameObject HairButtons;
    public GameObject PonyBaseButtons;
    public GameObject AccessoriesBaseButtons;

    void Start()
    {
        MainButtons.SetActive(true);
        HairButtons.SetActive(false);
        PonyBaseButtons.SetActive(false);
        AccessoriesBaseButtons.SetActive(false);
    }

    //Dress Menu
    public void Hair()
    {
        MainButtons.SetActive(false);
        HairButtons.SetActive(true);
        PonyBaseButtons.SetActive(false);
        AccessoriesBaseButtons.SetActive(false);
    }
    
    public void PonyBase()
    {
        MainButtons.SetActive(false);
        HairButtons.SetActive(false);
        PonyBaseButtons.SetActive(true);
        AccessoriesBaseButtons.SetActive(false);
    }

    public void Accessories()
    {
        MainButtons.SetActive(false);
        HairButtons.SetActive(false);
        PonyBaseButtons.SetActive(false);
        AccessoriesBaseButtons.SetActive(true);
    }

    public void Back()
    {
        MainButtons.SetActive(true);
        HairButtons.SetActive(false);
        PonyBaseButtons.SetActive(false);
        AccessoriesBaseButtons.SetActive(false);
    }

    //Hair
    public void HairB()
    {
        pony.HairCount--;
    }

    public void HairF()
    {
        pony.HairCount++;
    }

    public void HairColorF()
    {
        pony.ponyHairColor();
    }

    //Tail
    public void TailB()
    {
        pony.TailCount--;
    }

    public void TailF()
    {
        pony.TailCount++;
    }

    public void TailColorF()
    {
        pony.ponyTailColor();
    }

    //Pony Base
    public void BaseB()
    {
        pony.PonyBaseCount--;
    }

    public void BaseF()
    {
        pony.PonyBaseCount++;
    }

    public void BaseColorF()
    {
        pony.ponyBaseColor();
    }

    //Extra
    public void ExtraB()
    {
        pony.ExtraCount--;
    }

    public void ExtraF()
    {
        pony.ExtraCount++;
    }

    //Eye
    public void EyeB()
    {
        pony.EyeCount--;
    }

    public void EyeF()
    {
        pony.EyeCount++;
    }

    public void EyeColorF()
    {
        pony.ponyEyeColor();
    }

    //EyeWear
    public void EyewearB()
    {
        pony.EyewearCount--;
    }

    public void EyewearF()
    {
        pony.EyewearCount++;
    }

    public void EyewearColorF()
    {
        pony.ponyEyewearColor();
    }

    //Neckwear
    public void NeckwearB()
    {
        pony.NeckwearCount--;
    }

    public void NeckwearF()
    {
        pony.NeckwearCount++;
    }

    public void NeckwearColorF()
    {
        pony.ponyNeckwearColor();
    }
}
