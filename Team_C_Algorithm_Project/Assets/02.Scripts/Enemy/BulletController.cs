using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public float deleteTime = 2;  //���� �ð�

    // Use this for initialization
    void Start()
    {
        Destroy(gameObject, deleteTime); //���� �ð��� �����ϱ�
        
    }
}
