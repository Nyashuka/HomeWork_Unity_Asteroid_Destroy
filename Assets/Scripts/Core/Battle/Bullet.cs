﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private BulletPool _bulletPool;

    public void Init(BulletPool bulletPool)
    {
        _bulletPool = bulletPool;
    }

    private void OnTriggerEnter(Collider other)
    {
        //if (other.gameObject.TryGetComponent(out IDamageable damageable))
        //{
        //    if (!damageable.MakeDamage(_damage))
        //    {
        //        DeathActionEvent?.Invoke();
        //    }

        //    Destroy(gameObject);
        //}
    }
}

