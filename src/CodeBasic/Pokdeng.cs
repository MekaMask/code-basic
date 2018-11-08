using System;
using System.Collections.Generic;
using System.Text;

namespace CodeBasic
{
    public class Pokdeng
    {
        public int PlayerBalance { get; set; }

        // Club, Diamond, Heart, Spade (case sensitive)
        // 1 เป็นเจ้า
        // 2 player
        public void CheckGameResult(
            int betAmount,
            int p1CardNo1, int p1CardNo2, int p1CardNo3,
            string p1CardSymbol1, string p1CardSymbol2, string p1CardSymbol3,
            int p2CardNo1, int p2CardNo2, int p2CardNo3,
            string p2CardSymbol1, string p2CardSymbol2, string p2CardSymbol3)
        {
            var p1 = plus(p1CardNo1, p1CardNo2, p1CardNo3);
            var p2 = plus(p2CardNo1, p2CardNo2, p2CardNo3);

            if (p1 < p2)
            {
                PlayerBalance += betAmount;
            }
            else if (p1 == p2)
            {
                PlayerBalance = PlayerBalance;
            }
            PlayerBalance -= betAmount;
        }

        public int plus(int CardNo1, int CardNo2, int CardNo3)
        {
            int Number = CardNo1 + CardNo2 + CardNo3;
            if (Number > 9)
            {
                return Number - 9;
            }
            return Number;
        }

        public bool IscheckPok(int CardNo1, int CardNo2, int CardNo3)
        {

            throw new NotImplementedException();
        }
        public int pok8and9()
        {
            throw new NotImplementedException();
        }
    }
}
