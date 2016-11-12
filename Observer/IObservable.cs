namespace Observer
{
    interface IObservable
    {
        void RegisterObserver(IObserver observer);
        void UnregisterObserver(IObserver observer);
        void NotifyObservers();
    }
}