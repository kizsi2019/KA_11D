LinkedList<string> láncoltlista = new LinkedList<string>();
láncoltlista.AddLast("vár");
láncoltlista.AddLast("kávé");
láncoltlista.AddFirst("autó");
/*foreach (string item in láncoltlista){
    Console.WriteLine(item);
}*/
/*LinkedListNode<string> csomópont = láncoltlista.First;
Console.WriteLine(csomópont.Value);*/
Dictionary<string, string> szótár = new Dictionary<string, string>(){
    {"szín 1", "red"}, {"szín 2", "blue"}
};
foreach (KeyValuePair<string, string> item in szótár){
    Console.WriteLine("Kulcs: {0}, értéke: {1}", item.Key, item.Value);
}

if (szótár.ContainsKey("zöld")) Console.WriteLine("Van zöld");
else Console.WriteLine("Nincs zöld");