
List<string> listaString = new List<string>()
{
    "lista 1",
    "lista 2",
    "lista 3"
};

listaString.Add("Naranja");
listaString.Add("5");
listaString.Add("Real Espana");
listaString.Add("Barcelona");
listaString.Add("Real Madrid");
listaString.Add("Alajuela");
listaString.Insert(0, "Real Madrid");
//listaString.Remove("Real Madrid");//
//listaString.RemoveAt(10);// Tener cuidado de no agregar un indice fuera del rango
//listaString.RemoveAll(lista => lista.Contains("Real Madrid"));//

foreach (string item in listaString)
{
    //Console.WriteLine($"{listaString.IndexOf(item)}: {item}");//
    Console.WriteLine($"Item: {item}");
}