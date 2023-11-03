using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class PointSystem : MonoBehaviour
{
    public float points;

    [SerializeField] private TMP_Text text;

    private void Start()
    {
        text.SetText("00000");
    }
    private void Update()
    {
        text.SetText(points.ToString());
    }

    public void OnClick()
    {
        points += Random.Range(0, 1000);
    }
}
