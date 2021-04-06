using System;

namespace NakusiTest.Model
{

    public interface ICharacter
    {

        IObservable<int> healthAsObservable { get; }

    }

}