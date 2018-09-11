using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 顺序查找2
{
    class Program
    {
        /// <summary>
        /// 顺序查找2，折半查找
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 3,7,9,24,28};

            var result = BinarySearch(list,24);

            if(result!=-1)
            {
                Console.WriteLine("24 已经在数组中找到，索引为{0}",result);
            }
            else
            {
                Console.WriteLine("没有找到该数字");
            }
            Console.ReadKey();

        }

        public static int BinarySearch(List<int> list,int key)
        {
            //最低线
            int low = 0;
            //最高线
            int high = list.Count - 1;

            while(low<=high)
            {
                //取中间值
                var middle = (low + high) / 2;

                if(list[middle]==key)
                {
                    return middle;
                }
                else
                {
                    if(list[middle]>key)
                    {
                        //下降一半
                        high = middle - 1;
                    }
                    else
                    {
                        low = middle + 1;
                    }
                }               
            }
            return -1;


        }

    }
}
