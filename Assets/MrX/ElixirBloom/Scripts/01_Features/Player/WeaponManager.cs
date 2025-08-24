using System;
using System.Numerics;
using UnityEngine;

namespace ElixirBloom
{
    public class WeaponManager : MonoBehaviour
    {
        private Camera mainCam;
        // private Vector3 mousePos;
        [SerializeField] private GameObject bulletPrefabs;
        [SerializeField] private Transform firePos;
        [SerializeField] private float shotDelay = 0.15f;
        [SerializeField] private int maxAmo = 24;
        public int currentAmo;
        private float nextShot;
        void Awake()
        {
            // Lấy tham chiếu đến script cha
        }
        void Start()
        {
            currentAmo = maxAmo;
            mainCam = Camera.main; // Lấy camera chính của game
        }
        // public bool IsComponentNull()
        // {
        //     return m_anim == null;
        // }
        void Update()
        {
            // Reload();
        }
        public void Shoot(UnityEngine.Vector3 currentTarget, float currentDamage)
        {
            // Đọc hướng trực tiếp, không cần tính toán lại
            // Vector3 shootDirection = playerAim.AimDirection;
            if (Time.time > nextShot)
            {
                // Khi game vừa bắt đầu, phát nhạc loading/menu
                // AudioManager.Instance.PlaySFX(AudioManager.Instance.shootSFX);
                nextShot = Time.time + shotDelay;
                GameObject bulletObj = PoolManager.Ins.GetFromPool("PlayerBullet", firePos.position);
                Bullet bulletScript = bulletObj.GetComponent<Bullet>();
                // 4. "Ra lệnh" cho viên đạn bay theo hướng đã tính
                bulletScript.SetDirection(currentTarget, currentDamage);
                currentAmo--;
            }
        }
        void Reload()
        {
            if (Input.GetMouseButtonDown(1) && currentAmo <= 0)
            {
                currentAmo = maxAmo;
            }
        }
    }
}

