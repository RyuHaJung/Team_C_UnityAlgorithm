using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public float deleteTime = 2;  //제거 시간

    // Use this for initialization
    void Start()
    {
        Destroy(gameObject, deleteTime); //이정 시간후 제거하기
        
    }
}
