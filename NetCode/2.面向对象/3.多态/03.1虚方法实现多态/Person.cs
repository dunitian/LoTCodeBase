using System;

namespace _03._1虚方法实现多态
{
    public class Person
    {
        #region 字段+属性
        /// <summary>
        /// 姓名
        /// </summary>
        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }
        /// <summary>
        /// 性别
        /// </summary>
        private bool _gender;
        public bool Gender
        {
            get
            {
                return _gender;
            }

            set
            {
                _gender = value;
            }
        }
        /// <summary>
        /// 年龄
        /// </summary>
        public short Age { get; set; }
        #endregion

        #region 构造函数
        public Person() { }
        public Person(string name, bool gender)
        {
            this.Name = name;
            this.Gender = gender;
        }
        public Person(string name, bool gender, short age) : this(name, gender)
        {
            this.Age = age;
        }
        #endregion

        #region 方法
        /// <summary>
        /// 打招呼
        /// </summary>
        public virtual void SaiHi()
        {
            Console.WriteLine("我是一个人类！");
        }
        #endregion
    }
}
