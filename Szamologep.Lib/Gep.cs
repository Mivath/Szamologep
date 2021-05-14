using System;

namespace Szamologep.Lib
{
    public enum Szamjegyek
    {
        Szj_0 = 0,
        Szj_1 = 1,
        Szj_2 = 2,
        Szj_3 = 3,
        Szj_4 = 4,
        Szj_5 = 5,
        Szj_6 = 6,
        Szj_7 = 7,
        Szj_8 = 8,
        Szj_9 = 9,
    }
    public enum Unaris
    {
        EgyPerX,
        GyokX,
        XNegyzet,
        Negacio,
    }
    public enum Binaris
    {
        Osszead,
        Kivon,
        Szoroz,
        Oszt,
        Szazalek,
    }
    public class Gep
    {
        public Gep()
        {
            Ertek = "0";
        }

        private bool _vanTizedes = false;
        public string Ertek { get; private set; }
        public double ValosErtek => double.Parse(Ertek);


        public void Be(Szamjegyek be)
        {
            if (ValosErtek == 0 && !_vanTizedes)
                Ertek = $"{(int)be}";
            else
                Ertek = $"{Ertek}{(int)be}";
        }

        public void Be(Unaris be)
        {
            switch (be)
            {
                case Unaris.EgyPerX:
                    Ertek = $"{1 / ValosErtek}";
                    break;
                case Unaris.GyokX:
                    Ertek = $"{Math.Sqrt(ValosErtek)}";
                    break;
                case Unaris.XNegyzet:
                    Ertek = $"{ValosErtek * ValosErtek}";
                    break;
                case Unaris.Negacio:
                    Ertek = $"{-ValosErtek}";
                    break;
                default:
                    throw new NotImplementedException();
            }
        }

        public void Be(Binaris be)
        {

        }
        public void Tizedes()
        {
            if (_vanTizedes)
                return;

            Ertek = $"{Ertek}.";
            _vanTizedes = true;

        }

        public void Vissza()
        {
            if (Ertek.Length == 1)
                Ertek = "0";
            else
                Ertek = $"{Ertek.Substring(0, Ertek.Length - 1)}";
        }

        public void CE()
        {
            Ertek = "0";
            _vanTizedes = false;
        }
    }
}
