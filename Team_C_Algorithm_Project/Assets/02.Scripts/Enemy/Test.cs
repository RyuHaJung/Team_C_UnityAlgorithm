using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public int hp = 3;
    public GameObject itemPrefab; // ������ ������

    Rigidbody2D rbody; // Rigidbody 2D

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Enemy collided with Player");
            // �������� ����� �÷��̾��� HP ������ �����մϴ�.
            //PlayerController.hp -= 1;
        }

        if (collision.gameObject.CompareTag("Arrow"))
        {
            // ������
            hp--;
            if (hp <= 0)
            {
                // ���!
                // =====================
                // ��� ����
                // =====================

                // �浹 ���� ��Ȱ��
                GetComponent<CapsuleCollider2D>().enabled = false;

                // ������ ����
                Instantiate(itemPrefab, transform.position, Quaternion.identity);

                // 0.5�� �Ŀ� ����
                Destroy(gameObject, 0.05f);
            }
        }
    }
}
