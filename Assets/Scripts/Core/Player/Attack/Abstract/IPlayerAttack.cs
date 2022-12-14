using UnityEngine;

namespace Assets.Scripts.Core.Player.Attack.Abstract
{
    public interface IPlayerAttack
    {
        void Attack(ObjectPool<Bullet> pool, Vector3 basePosition);
    }
}
