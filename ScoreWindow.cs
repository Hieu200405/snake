using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreWindow : MonoBehaviour
//Thiet lap cua so tinh diem
{
    private Text scoreText;
    private void Awake()
    {
        scoreText = transform.Find("scoreText").GetComponent<Text>();
    }
    private void Update()
    {
        scoreText.text = GameHandler.GetScore().ToString();
    }
}
