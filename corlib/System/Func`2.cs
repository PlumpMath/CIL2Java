
namespace System
{
    /// <summary>Encapsulates a method that has one parameter and returns a value of the type specified by the <paramref name="TResult" /> parameter.</summary><returns>The return value of the method that this delegate encapsulates.</returns><param name="arg">The parameter of the method that this delegate encapsulates.</param><typeparam name="T">The type of the parameter of the method that this delegate encapsulates.This type parameter is contravariant. That is, you can use either the type you specified or any type that is less derived. For more information about covariance and contravariance, see Covariance and Contravariance in Generics.</typeparam><typeparam name="TResult">The type of the return value of the method that this delegate encapsulates.This type parameter is covariant. That is, you can use either the type you specified or any type that is more derived. For more information about covariance and contravariance, see Covariance and Contravariance in Generics.</typeparam><filterpriority>2</filterpriority>
    public delegate TResult Func<T, TResult>(T arg);
}
