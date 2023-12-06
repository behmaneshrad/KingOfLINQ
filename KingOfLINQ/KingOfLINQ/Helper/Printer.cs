using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingOfLINQ.Helper
{
    public static class Printer
    {
        public static void Print<T>(T item, string itemName)
        {
            MessageBox.Show($"{itemName}: {item}");
        }

        public static void Print<T>(IEnumerable<T> collection, string collectionName)
        {
            Print(collection, collectionName, "collection");
        }

        public static void Print<T>(IOrderedEnumerable<T> collection, string collectionName)
        {
            Print(collection as IEnumerable<T>, collectionName, "collection");
        }

        public static void Print<T>(List<T> collection, string collectionName)
        {
            Print(collection as IEnumerable<T>, collectionName, "collection");
        }

        public static void Print<T>(HashSet<T> hashSet, string hashSetName)
        {
            Print(hashSet, hashSetName, "HashSet");
        }

        private static void Print<T>(IEnumerable<T> collection, string collectionName, string collectionType)
        {
            MessageBox.Show($"{collectionName}:");
            if (collection.Any())
            {
                MessageBox.Show(string.Join("\n", collection.Select(elem => elem.ToString())));
            }
            else
            {
                MessageBox.Show($"The {collectionType} is empty!");
            }
        }

        public static void Print<TKey, TValue>(Dictionary<TKey, TValue> dictionary, string dictionaryName)
        {
            MessageBox.Show($"{dictionaryName}:");
            if (dictionary.Any())
            {
                MessageBox.Show(string.Join("\n", dictionary.Select(
                    elem => $"Key: {elem.Key}, Value: {elem.Value}")));
            }
            else
            {
                MessageBox.Show("The dictionary is empty!");
            }
        }

        public static void Print<TKey, TValue>(ILookup<TKey, TValue> lookup, string lookupName)
        {
            MessageBox.Show($"{lookupName}:");
            if (lookup.Any())
            {
                MessageBox.Show(string.Join("\n", lookup.Select(
                    elem => $"Key: {elem.Key}, Values (count: {lookup[elem.Key].Count()}): {string.Join(", ", lookup[elem.Key])}")));
            }
            else
            {
                MessageBox.Show("The lookup is empty!");
            }
        }
    }

}
