// 使い方 : main()関数のコメントを見て下さい
using System;

namespace miniroto5
{
    class Program
    {
        //private static readonly int[] src1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        //private static readonly int[] src2 = { 3, 12, 8, 5, 13, 10, 19, 18, 11, 15, 21, 22, 23, 24 };
        //private static readonly int[] src3 = { 14, 16, 19, 21, 22, 23, 24, 26, 27, 28 };
        //private static readonly int[] src4 = { 23, 24, 19, 16, 21, 22, 25, 26, 27, 28, 29 };
        //private static readonly int[] src5 = { 26, 27, 28, 29, 30, 31, 26, 27, 28, 29, 30, 31 };
        // 2桁目以降下位数字出現予想
        private static readonly int[] src1 = { 1, 11, 2, 12, 3, 13, 4, 14, 5, 15, 6, 16, 7, 17, 8, 9, 10, 1, 11, 2, 12, 3, 13, 4, 14, 5, 15, 6, 16, 7, 17, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17 };
        private static readonly int[] src2 = { 3, 12, 8, 5, 11, 7, 13, 10, 1, 19, 2, 18, 4, 6, 15, 21, 9, 22, 10, 23, 24, 1, 2, 3, 4, 5, 11, 12, 13, 14, 16, 17, 3, 12, 8, 5, 11, 7, 13, 10, 1, 19, 2, 18, 4, 6, 15, 21, 9, 22, 10, 23, 24, 1, 2, 3, 4, 5, 11, 12, 13, 14, 16, 17 };
        private static readonly int[] src3 = { 4, 12, 13, 20, 14, 1, 16, 2, 19, 3, 21, 5, 22, 11, 6, 23, 7, 24, 8, 25, 9, 26, 10, 27, 4, 28, 12, 13, 14, 1, 16, 2, 19, 3, 21, 5, 22, 11, 6, 23, 7, 24, 8, 25, 9, 26, 10, 27, 11, 28 };
        private static readonly int[] src4 = { 4, 25, 5, 26, 6, 27, 7, 29, 13, 23, 14, 24, 15, 20, 17, 21, 18, 21, 19, 22, 16, 11, 12, 13, 14, 15, 17, 18, 19, 20, 4, 25, 5, 26, 6, 27, 7, 29, 13, 23, 14, 24, 15, 20, 17, 21, 18, 21, 19, 22, 16, 11, 12, 13, 14, 15, 17, 18, 19, 20 };
        private static readonly int[] src5 = { 13, 23, 14, 24, 15, 25, 17, 26, 18, 27, 19, 28, 16, 20, 29, 21, 30, 22, 31, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 13, 23, 14, 24, 15, 25, 17, 26, 18, 27, 19, 28, 16, 20, 29, 21, 30, 22, 31, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

        static void genrotnum(Random rnd1, ref int[] roto)
        {
            int inum, i, ifnd;
            int icnt = 0;
            for (i = 0; i < roto.Length; i++)
            {
                roto[i] = 0;
            }

            ifnd = 1;
            while (ifnd == 1)
            {
                int num = rnd1.Next(0, src1.Length);
                inum = src1[num];
                ifnd = findsamenum(inum, icnt, roto);
                if (ifnd == 0)
                {
                    roto[icnt] = inum;
                    icnt++;
                }
            }

            ifnd = 1;
            while (ifnd == 1)
            {
                int num = rnd1.Next(0, src2.Length);
                inum = src2[num];
                ifnd = findsamenum(inum, icnt, roto);
                if (ifnd == 0)
                {
                    roto[icnt] = inum;
                    icnt++;
                }
            }

            ifnd = 1;
            while (ifnd == 1)
            {
                int num = rnd1.Next(0, src3.Length);
                inum = src3[num];
                ifnd = findsamenum(inum, icnt, roto);
                if (ifnd == 0)
                {
                    roto[icnt] = inum;
                    icnt++;
                }
            }

            ifnd = 1;
            while (ifnd == 1)
            {
                int num = rnd1.Next(0, src4.Length);
                inum = src4[num];
                ifnd = findsamenum(inum, icnt, roto);
                if (ifnd == 0)
                {
                    roto[icnt] = inum;
                    icnt++;
                }
            }

            ifnd = 1;
            while (ifnd == 1)
            {
                int num = rnd1.Next(0, src5.Length);
                inum = src5[num];
                ifnd = findsamenum(inum, icnt, roto);
                if (ifnd == 0)
                {
                    roto[icnt] = inum;
                    icnt++;
                }
            }

        }

        static int findsamenum(int inum, int icnt, int[] roto)
        {
            int ifnd = 0;
            // 同じ番号を弾く
            for (int i = 0; i < icnt; i++)
            {
                //if (inum == roto[i] || inum < roto[i])
                if (inum == roto[i])              // 次の数字は、前回の数字より下でも良い
                {
                    ifnd = 1;
                    break;
                }
            }
            if (ifnd == 1) return 1;
            else return 0;

        }

        static string getrotostring(int[] roto)
        {
            string strroto = new string("");
            for (int i = 0; i < roto.Length; i++)
            {
                strroto = strroto + roto[i].ToString() + " ";
            }
            return strroto;
        }

        static void Main(string[] args)
        {
            // 使用方法 : date1, atari1, date2を毎回設定します。
            // roto5の抽選時刻、当り番号を指定する
            // 前回抽選時刻（予想）
            DateTime date1 = new DateTime(2021, 8, 24, 19, 0, 0);
            // 前回当り番号
            int[] atari1 = { 3, 4, 16, 19, 27 };
            // 今回抽選時刻（予想）
            DateTime date2 = new DateTime(2021, 8, 31, 19, 0, 0);
            // 乱数初期化
            string datestr1 = date1.ToString("MMddHHmmss");
            int random1 = int.Parse(datestr1);
            Random rnd1;
            rnd1 = new System.Random(random1);
            string datestr2 = date2.ToString("MMddHHmmss");
            int random2 = int.Parse(datestr2);
            Random rnd2;
            rnd2 = new System.Random(random2);
            // 変数初期化
            // 5個の乱数を取り出す
            int[] roto = { 0, 0, 0, 0, 0 };
            int i, j;
            int num = 0;
            int ifind = 0;
            while (ifind == 0)
            {
                // 前回の当りが出るまで
                genrotnum(rnd1, ref roto);
                for (i = 0; i < atari1.Length; i++)
                {
                    for (j = 0; j < roto.Length; j++)
                    {
                        if (atari1[i] == roto[j])
                        {
                            ifind += 1;
                            break;
                        }
                    }
                }
                if (ifind == atari1.Length)
                {
                    int num1 = num;
                    string rotostr;
                    Console.WriteLine("前当たりくじ試行回数 = {0}", num);
                    rotostr = getrotostring(roto);
                    Console.WriteLine("前当たりくじロト５ = {0}", rotostr);
                    // 05/04 19時 抽選試行回数   6615469回
                    // 05/18 19時 抽選試行回数    407740回
                    // 06/01 19時 抽選試行回数     15164回   当選  6 8 11 24 29  4等2件  最初の５回で当たり出現
                    // 06/08 19時 抽選試行回数     47222回   当選  3 4 14 15 18
                    // 06/15 19時 抽選試行回数    251342回   当選  14 17 23 28 30
                    // 06/22 19時 抽選試行回数          回   当選  6 13 20 23 28
                    // 06/29 19時 抽選試行回数      1807回   当選  7 19 21 23 28
                    // 07/13 19時 抽選試行回数    355764回   当選  7 8 21 25 31
                    // 07/20 19時 抽選試行回数   1280814回   当選  14 20 23 28 29
                    // 07/27 19時 抽選試行回数    780875回   当選  12 16 17 24 31
                    // 08/10 19時 抽選試行回数    108948回   当選  09 12 17 18 27
                    // 08/17 19時 抽選試行回数    157916回   当選  11,23,25,29,30   試行回数再計算  再計算不可能
                    // 08/24 19時 抽選試行回数    474458回   当選  3,4,16,19,27     試行回数再計算  60934
                    // くじ計算
                    Console.WriteLine("ロト５　当たりくじ番号表示");
                    for (i = 0; i < num1; i++)
                    {
                        genrotnum(rnd2, ref roto);
                    }
                    for (j = 0; j < 10; j++)
                    {
                        genrotnum(rnd2, ref roto);
                        rotostr = getrotostring(roto);
                        Console.WriteLine("ロト５ = {0}", rotostr);
                    }
                    break;
                }
                ifind = 0;
                num += 1;
                if (num % 10000 == 0)
                {
                    Console.WriteLine("前回あたり回数計算・途中経過回数 = {0}", num);
                }
            }
        }
    }
}
