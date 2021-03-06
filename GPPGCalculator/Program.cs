﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPPGCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // 作った電卓のParserを生成する。
            // 字句解析器は、この中で生成されている。
            var parser = new Calculator.CalculatorParser();

            do
            {
                // 式を入力。空文字なら終了。
                Console.Write("> ");
                var input = Console.ReadLine();
                if (string.IsNullOrEmpty(input))
                {
                    return;
                }

                // 式を解析。この中で結果も出力される。
                parser.Parse(input);
            } while (true);
        }
    }
}
