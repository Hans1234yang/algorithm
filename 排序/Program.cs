using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 顺序查找1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int> {2,3,6,1,9,7 };

            var result = SequeceSearch(list, 5);

            if(result!=-1)
            {
                Console.WriteLine("5 在数组中找到， 索引的位置是,{0}",result);
            }
            else
            {
                Console.WriteLine("在数组中 没有");
            }
            Console.ReadLine();

        }
        /// <summary>
        /// 顺序查找
        /// </summary>
        /// <param name="list"></param>
        /// <param name="Key"></param>
        /// <returns></returns>
        static int SequeceSearch(List<int> list,int Key)
        {
            for(int i=0;i<list.Count;i++)
            {
                //查找成功，返回序列号
                if(Key==list[i])
                {
                    return i;
                }
            }
            //查找失败返回-1
            return -1;
        }
    }
}
