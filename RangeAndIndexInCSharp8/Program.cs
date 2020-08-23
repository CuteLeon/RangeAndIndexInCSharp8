using System;
using System.Linq;

namespace RangeAndIndexInCSharp8
{
    class Program
    {
        static void Main(string[] args)
        {
            var source = Enumerable.Range(1, 10).ToArray();

            // 从索引[2]取4个：3, 4, 5, 6
            Span<int> slice = source.AsSpan().Slice(2, 4);

            // 从索引[2]取到索引[4]之前（只包含开始索引，不包含结束索引）：3, 4
            var range = 2..4;
            var part = source[range];
            part = source[2..4];

            // 倒数第2个数字：9
            // [^0] 相当于 [.Length] 将会下标越界
            var index = ^2;
            var value = source[index];

            // 从索引[0]取到倒数索引[0]之前（全部元素）：1~10
            part = source[0..^0];
            // 简化写法
            part = source[..];

            // 组合使用 Index 和 Range: 5, 6, 7
            Index start = 4, end = ^3;
            range = start..end;
            part = source[range];

            Console.Read();
        }
    }
}
