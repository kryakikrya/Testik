using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Unity.Properties;
using UnityEngine;
using UnityEngine.UIElements;

public class ScorePlayerData : INotifyBindablePropertyChanged
{
    private int _score = 0;

    [CreateProperty]
    public int Score
    {
        get => _score;
        set
        {
            _score = value;
            Notify();
        }
    }

    public event EventHandler<BindablePropertyChangedEventArgs> propertyChanged;

    private void Notify([CallerMemberName] string property = "")
    {
        propertyChanged?.Invoke(
            this,
            new BindablePropertyChangedEventArgs(property));
    }
}