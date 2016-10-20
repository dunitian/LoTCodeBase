namespace 饲养员喂食案例
{
    public abstract class Animal : IEat
    {
        /// <summary>
        /// 动物名
        /// </summary>
        public abstract string Name { get; }
        /// <summary>
        /// 吃
        /// </summary>
        /// <param name="food"></param>
        public void Eat(Food food)
        {
            System.Console.WriteLine($"{Name}吃{food.Name}");
        }
    }
}
