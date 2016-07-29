namespace _03.Santase.GameLogic
{
    public interface IDeepCloneable<out T>
    {
        T DeepClone();
    }
}
