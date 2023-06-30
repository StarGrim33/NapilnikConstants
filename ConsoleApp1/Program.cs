namespace ConsoleApp1
{
    internal class Program
    {
        class Weapon
        {
            private int _bullets;

            public bool CanShoot() => _bullets > Constants.EmptyMag;

            public void Shoot() => _bullets -= Constants.BulletsPerShot;
        }

        class Constants
        {
            public static readonly int EmptyMag = 0;
            public static readonly int BulletsPerShot = 1;
        }
    }
}