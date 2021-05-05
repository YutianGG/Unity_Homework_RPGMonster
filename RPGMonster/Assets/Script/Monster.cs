using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    [Header("移動速度"),Range(0,10)]
    public float MoveSpeed = 3.5f;
    [Header("攻擊力"), Range(0, 500)]
    public float Attack = 100;
    [Header("血量"), Range(0, 5000)]
    public float HP = 350;
    [Header("掉落道具"), Tooltip("遊戲物件")]
    public bool Drop = false;
    [Header("掉落機率"), Range(0, 1)]
    public float DropOdds = 1;
    [Header("掉落道具與音效"), Tooltip("AudioClip")]
    public AudioClip AC;

    private AudioSource AS;
    private Rigidbody RB;
    private Animator AOR;
}
