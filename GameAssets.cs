using System.Collections;
using System.Collections.Generic;
using CodeMonkey;
using CodeMonkey.Utils;
using UnityEngine;
using System;

public class GameAssets : MonoBehaviour
{

    public static GameAssets i;

    private void Awake() {
        i = this;
    }

    public Sprite snakeHeadSprite;
    public Sprite snakeBodySprite;
    public Sprite foodSprite;
    public SoundAudioClip[] soundAudioClipsArray;
    [Serializable]
    public class SoundAudioClip
    {
        public SoundManager.Sound sound;
        public AudioClip audioClip;
    }
}
