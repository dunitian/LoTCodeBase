using System;

namespace _01.封装_类
{
    public class Student
    {
        /// <summary>
        /// 字段
        /// </summary>
        private int _age;
        /// <summary>
        /// 属性
        /// </summary>
        public int Age
        {
            get
            {
                return _age;
            }

            set
            {
                if (value > 1)
                {
                    _age = value;
                }
            }
        }

        /// <summary>
        /// 自动化属性
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 自动属性必须要有get访问器
        /// </summary>
        public string SNum { get; }

        private int _gender;
        public int Gender
        {
            set
            {
                _gender = value;
            }
        }

        /// <summary>
        /// 构造函数的名字必须与类名一致
        /// 构造函数没有返回值也没有viod
        /// 默认自动生成一个无参构造函数，当有一个有参构造函数的时候无参构造函数便不会自动创建
        /// </summary>
        public Student() { }

        /// <summary>
        /// 有参构造函数
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        public Student(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        /// <summary>
        /// this调用当前类的某个有参构造函数
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <param name="gender"></param>
        public Student(string name, int age, int gender) : this(name, age)
        {
            this.Gender = gender;
        }

        /// <summary>
        /// 某个方法
        /// </summary>
        public void Show()
        {
            Console.WriteLine("Name:" + this.Name + " Age:" + this.Age + "\n");
        }
    }
}
