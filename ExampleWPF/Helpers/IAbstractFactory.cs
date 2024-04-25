namespace ExampleWPF.Helpers;
public interface IAbstractFactory<T> {
    T Create();
}