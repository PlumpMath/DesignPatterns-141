namespace Observer
{
    interface IObservable
    {
        // event EventHandler SomethingHappened;

        void RegisterObserver(IObserver observer);
        void UnregisterObserver(IObserver observer);
        void NotifyObservers();
    }
}