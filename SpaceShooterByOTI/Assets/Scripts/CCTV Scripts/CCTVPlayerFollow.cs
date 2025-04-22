using System;
using System.Collections;
using UnityEngine;

public class CCTVPlayerFollow : MonoBehaviour
{
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private Transform _cameraTransform;
    [SerializeField] private float _playerRange = 5f;


    void Update()
    {
        if (IsPlayerInRange())
        {
            Debug.Log("Player is in range");
            _cameraTransform.LookAt(_playerTransform);
        }
    }

    void OnDrawGizmosSelected()
{
    Gizmos.color = Color.yellow;
    Gizmos.DrawWireSphere(transform.position, _playerRange);
}

    bool IsPlayerInRange()
    {
        float distance = Vector3.Distance(transform.position, _playerTransform.position);
        return distance <= _playerRange;
    }


}
