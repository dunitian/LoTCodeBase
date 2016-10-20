namespace 饲养员喂食案例
{
    /// <summary>
    /// 饲养员
    /// </summary>
    public class Person
    {
        /// <summary>
        /// 喂食
        /// </summary>
        /// <param name="animal"></param>
        /// <param name="food"></param>
        public void Feed(Animal animal, Food food)
        {
            animal.Eat(food);
        }
    }
}
