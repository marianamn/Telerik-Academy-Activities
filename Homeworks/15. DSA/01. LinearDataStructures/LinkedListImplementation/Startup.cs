// Implement the data structure linked list.
// 
// Define a class ListItem<T> that has two fields: value(of type T) and NextItem(of type ListItem<T>).
// Define additionally a class LinkedList<T> with a single field FirstElement(of type ListItem<T>).

namespace LinkedListImplementation
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            var store = new LinkedList<string>();

            var firstItemInStore = new ListItem<string>("Laptop");
            var secondItemInStore = new ListItem<string>("PC");
            var thirdItemInStore = new ListItem<string>("Monitor");
            var fourthItemInStore = new ListItem<string>("Mouse");
            var fifthItemInStore = new ListItem<string>("TV");
            var sixtItemInStore = new ListItem<string>("MP3");

            store.FirstItem = firstItemInStore;
            firstItemInStore.NextItem = secondItemInStore;
            secondItemInStore.NextItem = thirdItemInStore;
            thirdItemInStore.NextItem = fourthItemInStore;
            fourthItemInStore.NextItem = fifthItemInStore;
            fifthItemInStore.NextItem = sixtItemInStore;

            Console.WriteLine(string.Join(", ", store));
        }
    }
}
