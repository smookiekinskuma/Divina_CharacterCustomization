using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class PonyChange : MonoBehaviour
{
    public PonySprites pony;

    [Header("Counting")]
    public int TailCount;
    public int HairCount;
    public int PonyBaseCount;
    public int ExtraCount;
    public int EyeCount;
    public int EyewearCount;
    public int NeckwearCount;

    // Start is called before the first frame update
    void Start()
    {
        TailCount = 1;
        HairCount = 1;
        PonyBaseCount = 1;
        ExtraCount = 1;
        EyeCount = 1;
        EyewearCount = 1;
        NeckwearCount = 1;
    }

    // Update is called once per frame
    void Update()
    {
        ponyHairs();
        ponyTails();
        ponyBase();
        extraBase();
        ponyEye();
        ponyEyewear();
        ponyNeckwear();

        //Tail
        if (TailCount >= 8)
        {
            TailCount = 1;
        }
        else if (TailCount <= 0)
        {
            TailCount = 7;
        }

        //Hair
        if (HairCount >= 8)
        {
            HairCount = 1;
        }
        else if (HairCount <= 0)
        {
            HairCount = 7;
        }

        //Base
        if (PonyBaseCount >= 5)
        {
            PonyBaseCount = 1;
        }
        else if (PonyBaseCount <= 0)
        {
            PonyBaseCount = 4;
        }

        //Extra
        if (ExtraCount >= 5)
        {
            ExtraCount = 1;
        }
        else if (ExtraCount <= 0)
        {
            ExtraCount = 4;
        }

        //Eye
        if (EyeCount >= 4)
        {
            EyeCount = 1;
        }
        else if (EyeCount <= 0)
        {
            EyeCount = 3;
        }

        //Eyewear
        if (EyewearCount >= 5)
        {
            EyewearCount = 1;
        }
        else if (EyewearCount <= 0)
        {
            EyewearCount = 4;
        }

        //Neckwear
        if (NeckwearCount >= 5)
        {
            NeckwearCount = 1;
        }
        else if (NeckwearCount <= 0)
        {
            NeckwearCount = 4;
        }
    }

    /// <summary>
    /// Tail
    /// </summary>

    void ponyTails()
    { 
        switch (TailCount)
        {
            case 1:
                pony.Tail_1.SetActive(true);
                pony.Tail_2.SetActive(false);
                pony.Tail_3.SetActive(false);
                pony.Tail_4.SetActive(false);
                pony.Tail_5.SetActive(false);
                pony.Tail_6.SetActive(false);
                pony.Tail_7.SetActive(false);
                break;
            case 2:
                pony.Tail_1.SetActive(false);
                pony.Tail_2.SetActive(true);
                pony.Tail_3.SetActive(false);
                pony.Tail_4.SetActive(false);
                pony.Tail_5.SetActive(false);
                pony.Tail_6.SetActive(false);
                pony.Tail_7.SetActive(false);
                break;
            case 3:
                pony.Tail_1.SetActive(false);
                pony.Tail_2.SetActive(false);
                pony.Tail_3.SetActive(true);
                pony.Tail_4.SetActive(false);
                pony.Tail_5.SetActive(false);
                pony.Tail_6.SetActive(false);
                pony.Tail_7.SetActive(false);
                break;
            case 4:
                pony.Tail_1.SetActive(false);
                pony.Tail_2.SetActive(false);
                pony.Tail_3.SetActive(false);
                pony.Tail_4.SetActive(true);
                pony.Tail_5.SetActive(false);
                pony.Tail_6.SetActive(false);
                pony.Tail_7.SetActive(false);
                break;
            case 5:
                pony.Tail_1.SetActive(false);
                pony.Tail_2.SetActive(false);
                pony.Tail_3.SetActive(false);
                pony.Tail_4.SetActive(false);
                pony.Tail_5.SetActive(true);
                pony.Tail_6.SetActive(false);
                pony.Tail_7.SetActive(false);
                break;
            case 6:
                pony.Tail_1.SetActive(false);
                pony.Tail_2.SetActive(false);
                pony.Tail_3.SetActive(false);
                pony.Tail_4.SetActive(false);
                pony.Tail_5.SetActive(false);
                pony.Tail_6.SetActive(true);
                pony.Tail_7.SetActive(false);
                break;
            case 7:
                pony.Tail_1.SetActive(false);
                pony.Tail_2.SetActive(false);
                pony.Tail_3.SetActive(false);
                pony.Tail_4.SetActive(false);
                pony.Tail_5.SetActive(false);
                pony.Tail_6.SetActive(false);
                pony.Tail_7.SetActive(true);
                break;
        }
    }

    public void ponyTailColor()
    {
        int currentPonyTailIMGindex = pony.Tail1ColorList.IndexOf(pony.Tail_1.GetComponent<Image>().sprite);
        currentPonyTailIMGindex++;

        if(currentPonyTailIMGindex >= pony.Tail1ColorList.Count)
        {
            currentPonyTailIMGindex = 0;
        }
        pony.Tail_1.GetComponent<Image>().sprite = pony.Tail1ColorList[currentPonyTailIMGindex];
        pony.Tail_2.GetComponent<Image>().sprite = pony.Tail2ColorList[currentPonyTailIMGindex];
        pony.Tail_3.GetComponent<Image>().sprite = pony.Tail3ColorList[currentPonyTailIMGindex];
        pony.Tail_4.GetComponent<Image>().sprite = pony.Tail4ColorList[currentPonyTailIMGindex];
        pony.Tail_5.GetComponent<Image>().sprite = pony.Tail5ColorList[currentPonyTailIMGindex];
        pony.Tail_6.GetComponent<Image>().sprite = pony.Tail6ColorList[currentPonyTailIMGindex];
        pony.Tail_7.GetComponent<Image>().sprite = pony.Tail7ColorList[currentPonyTailIMGindex];
    }

    /// <summary>
    /// Hair
    /// </summary>

    public void ponyHairs()
    {
        switch (HairCount)
        {
            case 1:
                pony.Hair_1.SetActive(true);
                pony.Hair_2.SetActive(false);
                pony.Hair_3.SetActive(false);
                pony.Hair_4.SetActive(false);
                pony.Hair_5.SetActive(false);
                pony.Hair_6.SetActive(false);
                pony.Hair_7.SetActive(false);
                break;
            case 2:
                pony.Hair_1.SetActive(false);
                pony.Hair_2.SetActive(true);
                pony.Hair_3.SetActive(false);
                pony.Hair_4.SetActive(false);
                pony.Hair_5.SetActive(false);
                pony.Hair_6.SetActive(false);
                pony.Hair_7.SetActive(false);
                break;
            case 3:
                pony.Hair_1.SetActive(false);
                pony.Hair_2.SetActive(false);
                pony.Hair_3.SetActive(true);
                pony.Hair_4.SetActive(false);
                pony.Hair_5.SetActive(false);
                pony.Hair_6.SetActive(false);
                pony.Hair_7.SetActive(false);
                break;
            case 4:
                pony.Hair_1.SetActive(false);
                pony.Hair_2.SetActive(false);
                pony.Hair_3.SetActive(false);
                pony.Hair_4.SetActive(true);
                pony.Hair_5.SetActive(false);
                pony.Hair_6.SetActive(false);
                pony.Hair_7.SetActive(false);
                break;
            case 5:
                pony.Hair_1.SetActive(false);
                pony.Hair_2.SetActive(false);
                pony.Hair_3.SetActive(false);
                pony.Hair_4.SetActive(false);
                pony.Hair_5.SetActive(true);
                pony.Hair_6.SetActive(false);
                pony.Hair_7.SetActive(false);
                break;
            case 6:
                pony.Hair_1.SetActive(false);
                pony.Hair_2.SetActive(false);
                pony.Hair_3.SetActive(false);
                pony.Hair_4.SetActive(false);
                pony.Hair_5.SetActive(false);
                pony.Hair_6.SetActive(true);
                pony.Hair_7.SetActive(false);
                break;
            case 7:
                pony.Hair_1.SetActive(false);
                pony.Hair_2.SetActive(false);
                pony.Hair_3.SetActive(false);
                pony.Hair_4.SetActive(false);
                pony.Hair_5.SetActive(false);
                pony.Hair_6.SetActive(false);
                pony.Hair_7.SetActive(true);
                break;
        }
    }

    public void ponyHairColor()
    {
        int currentPonyHairIMGindex = pony.Hair1ColorList.IndexOf(pony.Hair_1.GetComponent<Image>().sprite);
        currentPonyHairIMGindex++;

        if (currentPonyHairIMGindex >= pony.Hair1ColorList.Count)
        {
            currentPonyHairIMGindex = 0;
        }
        pony.Hair_1.GetComponent<Image>().sprite = pony.Hair1ColorList[currentPonyHairIMGindex];
        pony.Hair_2.GetComponent<Image>().sprite = pony.Hair2ColorList[currentPonyHairIMGindex];
        pony.Hair_3.GetComponent<Image>().sprite = pony.Hair3ColorList[currentPonyHairIMGindex];
        pony.Hair_4.GetComponent<Image>().sprite = pony.Hair4ColorList[currentPonyHairIMGindex];
        pony.Hair_5.GetComponent<Image>().sprite = pony.Hair5ColorList[currentPonyHairIMGindex];
        pony.Hair_6.GetComponent<Image>().sprite = pony.Hair6ColorList[currentPonyHairIMGindex];
        pony.Hair_7.GetComponent<Image>().sprite = pony.Hair7ColorList[currentPonyHairIMGindex];
    }

    /// <summary>
    /// Base
    /// </summary>

    public void ponyBase()
    {
        switch (PonyBaseCount)
        {
            case 1:
                pony.PonyBase_1.SetActive(true);
                pony.PonyBase_2.SetActive(false);
                pony.PonyBase_3.SetActive(false);
                pony.PonyBase_4.SetActive(false); 
                break;
            case 2:
                pony.PonyBase_1.SetActive(false);
                pony.PonyBase_2.SetActive(true);
                pony.PonyBase_3.SetActive(false);
                pony.PonyBase_4.SetActive(false);
                break;
            case 3:
                pony.PonyBase_1.SetActive(false);
                pony.PonyBase_2.SetActive(false);
                pony.PonyBase_3.SetActive(true);
                pony.PonyBase_4.SetActive(false);
                break;
            case 4:
                pony.PonyBase_1.SetActive(false);
                pony.PonyBase_2.SetActive(false);
                pony.PonyBase_3.SetActive(false);
                pony.PonyBase_4.SetActive(true);
                break;
        }
    }

    public void extraBase()
    {
        switch (ExtraCount) 
        {
            case 1:
                pony.Wing.SetActive(false);
                pony.Horn.SetActive(false);
                break;
            case 2:
                pony.Wing.SetActive(true);
                pony.Horn.SetActive(false);
                break;
            case 3:
                pony.Wing.SetActive(false);
                pony.Horn.SetActive(true);
                break;
            case 4:
                pony.Wing.SetActive(true);
                pony.Horn.SetActive(true);
                break;
        }
    }

    public void ponyBaseColor()
    {
        int currentPonyBaseIMGindex = pony.PonyBase1.IndexOf(pony.PonyBase_1.GetComponent<Image>().sprite);
        currentPonyBaseIMGindex++;

        if (currentPonyBaseIMGindex >= pony.PonyBase1.Count)
        {
            currentPonyBaseIMGindex = 0;
        }
        pony.PonyBase_1.GetComponent<Image>().sprite = pony.PonyBase1[currentPonyBaseIMGindex];
        pony.PonyBase_2.GetComponent<Image>().sprite = pony.PonyBase2[currentPonyBaseIMGindex];
        pony.PonyBase_3.GetComponent<Image>().sprite = pony.PonyBase3[currentPonyBaseIMGindex];
        pony.PonyBase_4.GetComponent<Image>().sprite = pony.PonyBase4[currentPonyBaseIMGindex];
        //Extras
        pony.Wing.GetComponent<Image>().sprite = pony.WingColor[currentPonyBaseIMGindex];
        pony.Horn.GetComponent<Image>().sprite = pony.HornColor[currentPonyBaseIMGindex];
    }

    /// <summary>
    /// Eye
    /// </summary>

    public void ponyEye()
    {
        switch (EyeCount)
        {
            case 1:
                pony.Eye_1.SetActive(true);
                pony.Eye_2.SetActive(false);
                pony.Eye_3.SetActive(false);
                break;
            case 2:
                pony.Eye_1.SetActive(false);
                pony.Eye_2.SetActive(true);
                pony.Eye_3.SetActive(false);
                break;
            case 3:
                pony.Eye_1.SetActive(false);
                pony.Eye_2.SetActive(false);
                pony.Eye_3.SetActive(true);
                break;
        }
    }

    public void ponyEyeColor()
    {
        int currentPonyEyesIMGindex = pony.Eyes1.IndexOf(pony.Eye_1.GetComponent<Image>().sprite);
        currentPonyEyesIMGindex++;

        if (currentPonyEyesIMGindex >= pony.Eyes1.Count)
        {
            currentPonyEyesIMGindex = 0;
        }
        pony.Eye_1.GetComponent<Image>().sprite = pony.Eyes1[currentPonyEyesIMGindex];
        pony.Eye_2.GetComponent<Image>().sprite = pony.Eyes2[currentPonyEyesIMGindex];
        pony.Eye_3.GetComponent<Image>().sprite = pony.Eyes3[currentPonyEyesIMGindex];
    }

    /// <summary>
    /// Eyewear
    /// </summary>

    public void ponyEyewear()
    {
        switch (EyewearCount)
        {
            case 1:
                pony.Eyewear_1.SetActive(false);
                pony.Eyewear_2.SetActive(false);
                pony.Eyewear_3.SetActive(false);
                break;
            case 2:
                pony.Eyewear_1.SetActive(true);
                pony.Eyewear_2.SetActive(false);
                pony.Eyewear_3.SetActive(false);
                break;
            case 3:
                pony.Eyewear_1.SetActive(false);
                pony.Eyewear_2.SetActive(true);
                pony.Eyewear_3.SetActive(false);
                break;
            case 4:
                pony.Eyewear_1.SetActive(false);
                pony.Eyewear_2.SetActive(false);
                pony.Eyewear_3.SetActive(true);
                break;
        }
    }

    public void ponyEyewearColor()
    {
        int currentPonyEyewearIMGindex = pony.Eyewear1.IndexOf(pony.Eyewear_1.GetComponent<Image>().sprite);
        currentPonyEyewearIMGindex++;

        if (currentPonyEyewearIMGindex >= pony.Eyewear1.Count)
        {
            currentPonyEyewearIMGindex = 0;
        }
        pony.Eyewear_1.GetComponent<Image>().sprite = pony.Eyewear1[currentPonyEyewearIMGindex];
        pony.Eyewear_3.GetComponent<Image>().sprite = pony.Eyewear3[currentPonyEyewearIMGindex];
    }

    /// <summary>
    /// 
    /// </summary>

    public void ponyNeckwear()
    {
        switch (NeckwearCount)
        {
            case 1:
                pony.Neckwear_1.SetActive(false);
                pony.Neckwear_2.SetActive(false);
                pony.Neckwear_3.SetActive(false);
                break;
            case 2:
                pony.Neckwear_1.SetActive(true);
                pony.Neckwear_2.SetActive(false);
                pony.Neckwear_3.SetActive(false);
                break;
            case 3:
                pony.Neckwear_1.SetActive(false);
                pony.Neckwear_2.SetActive(true);
                pony.Neckwear_3.SetActive(false);
                break;
            case 4:
                pony.Neckwear_1.SetActive(false);
                pony.Neckwear_2.SetActive(false);
                pony.Neckwear_3.SetActive(true);
                break;
        }
    }

    public void ponyNeckwearColor()
    {
        int currentPonyNeckwearIMGindex = pony.Neckwear1.IndexOf(pony.Neckwear_1.GetComponent<Image>().sprite);
        currentPonyNeckwearIMGindex++;

        if (currentPonyNeckwearIMGindex >= pony.Neckwear1.Count)
        {
            currentPonyNeckwearIMGindex = 0;
        }
        pony.Neckwear_1.GetComponent<Image>().sprite = pony.Neckwear1[currentPonyNeckwearIMGindex];
        pony.Neckwear_2.GetComponent<Image>().sprite = pony.Neckwear2[currentPonyNeckwearIMGindex];
        pony.Neckwear_3.GetComponent<Image>().sprite = pony.Neckwear3[currentPonyNeckwearIMGindex];
    }
}
