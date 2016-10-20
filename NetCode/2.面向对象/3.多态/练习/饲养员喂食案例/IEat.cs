namespace 饲养员喂食案例
{
    /// <summary>
    /// 吃
    /// </summary>
    public interface IEat
    {      
        /// <summary>
        /// 吃的方法
        /// </summary>
        /// <param name="food">食物对象</param>
        void Eat(Food food);
    }
}
