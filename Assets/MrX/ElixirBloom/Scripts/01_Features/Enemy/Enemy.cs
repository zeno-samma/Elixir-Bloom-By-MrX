using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace ElixirBloom
{
    public class Enemy : MonoBehaviour
    {
        [Header("UI")]
        // "Bộ não" giữ tham chiếu đến các "bộ phận"
        public EnemyHealth Health { get; private set; }
        public RangedEnemy rangedEnemy { get; private set; }
        void Awake()
        {
            // Tự động lấy các bộ phận của mình
            Health = GetComponent<EnemyHealth>();
            rangedEnemy = GetComponent<RangedEnemy>();
        }
        // OnEnable và OnDisable để đăng ký/hủy đăng ký với EnemyManager
        void OnEnable()
        {
            // if (EnemyManager.Ins != null)
            // {
            //     EnemyManager.Ins.RegisterEnemy(this);
            // }
        }

        void OnDisable()
        {
            // if (EnemyManager.Ins != null)
            // {
            //     EnemyManager.Ins.UnregisterEnemy(this);
            // }
        }
    }
}
