using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackBoostItem : MonoBehaviour
{
    public int attackBoostAmount = 1; // ������ų ���ݷ·�

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // �÷��̾� ��Ʈ�ѷ� ��ũ��Ʈ ��������
            PlayerController playerController = other.GetComponent<PlayerController>();
            if (playerController != null)
            {
                // �÷��̾��� ���ݷ��� ������Ű��
                playerController.IncreaseAttack(attackBoostAmount);
                // �������� ȹ�������Ƿ� �ش� ������ ����
                Destroy(gameObject);
            }
        }
    }
}
