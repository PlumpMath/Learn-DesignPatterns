using System;
using System.Collections;
using System.Collections.Generic;

namespace Builder
{
    /// <summary>
    /// 最终的产品
    /// </summary>
    public class Product
    {
        IList<string> parts = new List<string>();

        /// <summary>
        /// 添加产品部件
        /// </summary>
        /// <param name="part"></param>
        public void Add(string part)
        {
            parts.Add(part);
        }

        public void Show()
        {
            Console.WriteLine("\n 创建产品----");
            foreach (var part in parts)
            {
                Console.WriteLine(part);
            }
        }
    }
}