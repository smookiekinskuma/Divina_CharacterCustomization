using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PonySprites : MonoBehaviour
{
    /// <summary>
    /// Hairs
    /// </summary>

    [Header("Tails")]
    public GameObject Tail_1;
    public GameObject Tail_2;
    public GameObject Tail_3;
    public GameObject Tail_4;
    public GameObject Tail_5;
    public GameObject Tail_6;
    public GameObject Tail_7;

    [Header("Hairs")]
    public GameObject Hair_1;
    public GameObject Hair_2;
    public GameObject Hair_3;
    public GameObject Hair_4;
    public GameObject Hair_5;
    public GameObject Hair_6;
    public GameObject Hair_7;

    [Header("TailColor")]
    public List<Sprite> Tail1ColorList = new();
    public List<Sprite> Tail2ColorList = new();
    public List<Sprite> Tail3ColorList = new();
    public List<Sprite> Tail4ColorList = new();
    public List<Sprite> Tail5ColorList = new();
    public List<Sprite> Tail6ColorList = new();
    public List<Sprite> Tail7ColorList = new();

    [Header("HairColor")]
    public List<Sprite> Hair1ColorList = new();
    public List<Sprite> Hair2ColorList = new();
    public List<Sprite> Hair3ColorList = new();
    public List<Sprite> Hair4ColorList = new();
    public List<Sprite> Hair5ColorList = new();
    public List<Sprite> Hair6ColorList = new();
    public List<Sprite> Hair7ColorList = new();

    /// <summary>
    /// PonyBase
    /// </summary>

    [Header("PonyBase")]
    public GameObject PonyBase_1;
    public GameObject PonyBase_2;
    public GameObject PonyBase_3;
    public GameObject PonyBase_4;

    [Header("Eyes")]
    public GameObject Eye_1;
    public GameObject Eye_2;
    public GameObject Eye_3;

    [Header("Extra")]
    public GameObject Wing;
    public GameObject Horn;

    [Header("PonyBaseColor")]
    public List<Sprite> PonyBase1 = new();
    public List<Sprite> PonyBase2 = new();
    public List<Sprite> PonyBase3 = new();
    public List<Sprite> PonyBase4 = new();

    [Header("EyesColor")]
    public List<Sprite> Eyes1 = new();
    public List<Sprite> Eyes2 = new();
    public List<Sprite> Eyes3 = new();

    [Header("HornsColor")]
    public List<Sprite> HornColor = new();

    [Header("WingsColor")]
    public List<Sprite> WingColor = new();

    /// <summary>
    /// Accessories
    /// </summary>

    [Header("Neckwear Extra")]
    public GameObject Neckwear_1;
    public GameObject Neckwear_2;
    public GameObject Neckwear_3;

    [Header("Eyewear Extra")]
    public GameObject Eyewear_1;
    public GameObject Eyewear_2;
    public GameObject Eyewear_3;

    [Header("NeckwearColor")]
    public List<Sprite> Neckwear1 = new();
    public List<Sprite> Neckwear2 = new();
    public List<Sprite> Neckwear3 = new();

    [Header("EyewearColor")]
    public List<Sprite> Eyewear1 = new();
    public List<Sprite> Eyewear2 = new();
    public List<Sprite> Eyewear3 = new();
}
