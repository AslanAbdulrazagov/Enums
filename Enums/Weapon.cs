using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    public class Weapon
    {
        private static int _id = 1;
        public int Id { get; private set; }
        public BulletType BulletType { get; private set; }
        public int Capacity { get; private set; }
        private Stack<Bullet> _ammo;

        public Weapon(BulletType bulletType, int capacity)
        {
            Id = _id++;
            BulletType = bulletType;
            Capacity = capacity;
            _ammo = new Stack<Bullet>(capacity);
        }

        public void Fill()
        {
            for (int i = 0; i < Capacity; i++)
            {
                if (_ammo.Count < Capacity)
                {
                    _ammo.Push(new Bullet(BulletType));
                }
            }
        }

        public void Fire()
        {
            if (_ammo.Count > 0)
            {
                Bullet firedBullet = _ammo.Pop();
                Console.WriteLine($"Fired {firedBullet}. Bullets count: {_ammo.Count}");
            }
            else
            {
                Console.WriteLine("Dont have bullets!");
            }
        }

        public void PullTrigger()
        {
            if (_ammo.Count > 0)
            {
                Bullet nextBullet = _ammo.Peek();
                Console.WriteLine($"you can fire this bullet: {nextBullet}");
            }
            else
            {
                Console.WriteLine("No bullets in the next.");
            }
        }
    }

    
}
