using System;

namespace _02.继承
{
    public class Student : People
    {
        #region 属性
        /// <summary>
        /// 学校
        /// </summary>
        public string School { get; set; }
        /// <summary>
        /// 班级
        /// </summary>
        public string StrClass { get; set; }
        /// <summary>
        /// 学号
        /// </summary>
        public string StrNum { get; set; }
        #endregion

        #region 构造函数
        /// <summary>
        /// 调用父类构造函数
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        public Student(string name, ushort age) : base(name, age)
        {

        }
        public Student(string name, ushort age, string school, string strClass, string strNum) : this(name, age)
        {
            this.School = school;
            this.StrClass = strClass;
            this.StrNum = strNum;
        } 
        #endregion

        /// <summary>
        /// new-隐藏
        /// </summary>
        public new void Hi()//Student
        {
            Console.WriteLine("Name: " + this.Name + " Age: " + this.Age + " School: " + this.School + " strClass: " + this.StrClass + " strNum: " + this.StrNum);
        }
        /// <summary>
        /// override-覆盖
        /// </summary>
        public override void Show()//Student
        {
            Console.WriteLine("Name: " + this.Name + " Age: " + this.Age + " School: " + this.School + " strClass: " + this.StrClass + " strNum: " + this.StrNum);
        }
    }
}
