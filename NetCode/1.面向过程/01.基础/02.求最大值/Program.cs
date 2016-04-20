using System;

namespace _02.求最大值
{
    class Program
    {
        #region 声明方法
        /*
         * 声明方法：
         * 访问修饰符  返回值类型  方法名称(方法形参)｛方法体｝
         * 访问修饰符：
         *       public :公共的：任何类（如果类没有标记为public,同一个命名空间）都能够访问,如果类也是public，那么就可以跨命名空间访问
         *       private:私有的：只有当前类可以使用
         *       protected:受保护的：在父类和子类中可以使用
         *       internal:在当前程序集中可以使用

         * 返回值类型
         *      void:没有返回值，可以使用return来结束方法，但是不能使用return来返回具体的数据
         *      非void:必须返回与类型一致的数据

         *  方法名称的命名规则：pascal:每一个单词的首字母都大写

         *  方法参数：一 一对应（类型对应，数量对应，顺序对应）
         *      实参：实参相当于为形参赋值（值类型赋值是值的副本   引用 类型赋值是地址引用的副本）
         *      形参：形参是实参的规范，形参虽然是一种规范，但是在调用的时候需要独立的内存空间，它也是一个变量
         */
        #endregion
        static void Main(string[] args)
        {
            Console.WriteLine(GetMaxNum(null));
            Console.WriteLine(GetMaxNum(new int[0]));
            Console.WriteLine(GetMaxNum(1, 7, 9, 8, 10, 22, 2, 4));
            Console.ReadKey();
        }

        #region 方法的调用
        /*
        * 方法的调用：
        * 如果对于方法是静态方法(静态成员)：
        *  1.如果是同一个类：
        *     A：静态可以自由调用静态
        *     B：静态却不能直接调用非静态(实例)，实例成员需要通过类的对象调用:因为静态成员的生成是与类一起生成，它在对象生成之前。有静态的时候还没有实例成员，但是有实例成员的时候静态已经存在 
        *     C：实例可以自由调用实例成员和静态成员。
        *   2.不同类之间的方法调用：
        *      A：实例成员都需要通过对象调用 
        *      B：静态成员通过类名调用
        */
        #endregion
        /// <summary>
        /// 求未知个数集合的最大值（int类型）
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int GetMaxNum(params int[] nums)
        {
            int maxNum = int.MinValue;
            if (nums == null) { return maxNum; }
            for (int i = 0; i < nums.Length; i++)
            {
                maxNum = nums[i] > maxNum ? nums[i] : maxNum;
            }
            return maxNum;
        }
    }
}
