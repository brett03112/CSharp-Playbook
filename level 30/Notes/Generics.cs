﻿using System.Collections.Generic;
using System.Linq;

namespace Notes;
/*
    Generics and Collections defining and how to use them

    A generic type is a type definition (class, struct, or interface) that leaves a placeholder for some
    of the types it uses. This is conceptually similar to making methods with parameters, allowing
    the outside world to supply a value. The easiest way to show a generic type is with an example
    of a generic List class:
*/

/// <summary>
/// A User defined List<typeparamref name="T"/>
/// </summary>
/// <typeparam name="T"></typeparam> <summary>
/// <returns>
/// A List<typeparamref name="T"/> where T is a generic type parameter
/// </returns>
/// <typeparam name="T"></typeparam>
/// <exception cref="ArgumentOutOfRangeException: 
/// Index was out of range. Must be non-negative and less than the size of the collection.
/// Parameter name: index">
/// Thrown when the index is out of range
/// </exception>
public class List<T>
{
    private T[] _items = new T[0];

    /// <summary>
    /// Gets an item from the list
    /// </summary>
    /// <param name="index">The index of the item to get</param>
    /// <returns>The item at the specified index</returns>
    public T GetItemAt(int index) => _items[index];

    /// <summary>
    /// Sets an item in the list
    /// </summary>
    /// <param name="index">The index of the item to set</param>
    /// <param name="value">The value to set the item to</param>
    public void SetItemAt(int index, T value) => _items[index] = value;

    /// <summary>
    /// Gets the number of items in the list
    /// </summary>
    /// <returns>The number of items in the list</returns>
    public int Count() => _items.Length;

    /// <summary>
    /// Adds an item to the list.
    /// </summary>
    /// <param name="newValue">The value to add</param>
    /// <remarks>
    /// This works by creating a new array one element longer than the existing one,
    /// then copying all the existing elements to the new array and adding the new element
    /// at the end.
    /// </remarks>
    public void Add(T newValue)
    {
        T[] updated = new T[_items.Length + 1];

        for (int i = 0; i < _items.Length; i++)
        {
            updated[i] = _items[i];
        }

        updated[^1] = newValue;

        _items = updated;
    }


    /// <summary>
    /// Creates a new list of the given value repeated the given number of times.
    /// </summary>
    /// <param name="value">The value to repeat</param>
    /// <param name="times">The number of times to repeat <paramref name="value"/></param>
    /// <returns>A new list containing <paramref name="value"/> <paramref name="times"/> times</returns>
    public static List<T> Repeat<T>(T value, int times)
    {
        List<T> list = new List<T>();
        for (int i = 0; i < times; i++)
        {
            list.Add(value);
        }

        return list;
    }

    /// <summary>
    /// Finds an item in the list based on the given value checker.
    /// </summary>
    /// <param name="value">A function that takes an object and returns true if it matches the value to find</param>
    /// <returns>The item in the list that matches the value checker, or null if none is found</returns>
    internal T? Find(Func<object, bool> value)
    {
        throw new NotImplementedException();
    }
}

// An example of type constraints

public abstract class GameObject
{
    public int ID {get; }
    public int Width { get; set; }
    public int Height { get; set; }
}

public class IDList<T> where T: GameObject
{
    private T[] items = new T[0];
    
    public T? GetItemByID(int idToFind)
    {
        foreach (T item in items)
        {
            if (item.ID == idToFind)
            {
                return item;
            }
        }

        return null;


    }
}

    