﻿using System;

namespace Szamologep.Lib
{
    public class Gep
    {
        public Gep()
        {
            Ertek = "0";
        }

        private bool _vanTizedes = false;
        private bool _ezEredmeny = false;
        private double _operandus1;
        private Binaris _muvelet;
        public string Ertek { get; private set; }
        public double ValosErtek => double.Parse(Ertek);

        public void Be(Szamjegyek be)
        {
            if ((ValosErtek == 0 && !_vanTizedes) || _ezEredmeny)
                Ertek = $"{(int)be}";
            else
                Ertek = $"{Ertek}{(int)be}";
            _ezEredmeny = false;
        }

        public void Be(Unaris be)
        {
            switch (be)
            {
                case Unaris.EgyPerX:
                    Ertek = $"{1 / ValosErtek}";
                    _ezEredmeny = true;
                    break;
                case Unaris.GyokX:
                    Ertek = $"{Math.Sqrt(ValosErtek)}";
                    _ezEredmeny = true;
                    break;
                case Unaris.XNegyzet:
                    Ertek = $"{ValosErtek * ValosErtek}";
                    _ezEredmeny = true;
                    break;
                case Unaris.Negacio:
                    Ertek = $"{-ValosErtek}";
                    _ezEredmeny = true;
                    break;
                case Unaris.Szazalek:
                    Ertek = $"{ValosErtek / 100}";
                    _ezEredmeny = true;
                    break;
                default:
                    throw new NotImplementedException();
            }
        }

        public void Egyenlo()
        {
            switch (_muvelet)
            {
                case Binaris.Osszead:
                    Ertek = $"{_operandus1 + ValosErtek}";
                    break;
                case Binaris.Kivon:
                    Ertek = $"{_operandus1 - ValosErtek}";
                    break;
                case Binaris.Szoroz:
                    Ertek = $"{_operandus1 * ValosErtek}";
                    break;
                case Binaris.Oszt:
                    Ertek = $"{_operandus1 / ValosErtek}";
                    break;
                default:
                    throw new NotImplementedException();
            }
            _ezEredmeny = true;
        }

        public void Be(Binaris be)
        {
            _operandus1 = ValosErtek;
            _muvelet = be;
            _ezEredmeny = true;
            _vanTizedes = false;
        }
        public void Tizedes()
        {
            if (_ezEredmeny)
            {
                Ertek = "0";
                _ezEredmeny = false;
            }
            
            if (_vanTizedes)
                return;

            Ertek = $"{Ertek}.";
            _vanTizedes = true;

        }

        public void Vissza()
        {
            if (_ezEredmeny)
                return; //nincs hatasa

            if (Ertek.Length == 1)
                Ertek = "0";
            else
                Ertek = $"{Ertek.Substring(0, Ertek.Length - 1)}";
        }

        public void CE()
        {
            Ertek = "0";
            _vanTizedes = false;
            _ezEredmeny = false;
        }

        public void C()
        {
            Ertek = "0";
            _operandus1 = 0;
            _vanTizedes = false;
            _ezEredmeny = false;
        }
    }
}
