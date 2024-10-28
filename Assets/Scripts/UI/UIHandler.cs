using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIHandler : MonoBehaviour
{
    [SerializeField] private TMPro.TMP_Text hexagonText;

    public void OnCollectingHexagon(Component invoker, object data)
    {
        int score = (int)data;
        hexagonText.text = "Hexagons collected: " + score.ToString();
    }
}
