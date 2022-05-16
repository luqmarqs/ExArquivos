using ExArquivos;

string path = @"C:\Users\Lucas Marques\Documents\ExArquivos";

List<Product> products = new List<Product>();

try
{
    string [] lines = File.ReadAllLines(path);

    foreach(string line in lines)
    {
        string [] words = line.Split(',');
        string name = words[0];
        double price = double.Parse(words[1]);
        int qtd = int.Parse(words[2]);
        
        Product product = new Product(name, price, qtd);
        products.Add(product);
    }
    string newPath = path + @"\out";
    Directory.CreateDirectory(newPath);
    FileStream fs2 = File.Create(newPath + @"\summary");
    foreach(Product product in products)
    {
        StreamWriter sw = new StreamWriter(fs2);
        sw.Write(product.Name + "," + product.Price*product.Qtd + "\n");
    }

}
catch (IOException e)
{
    Console.WriteLine("Erro!");
    Console.WriteLine(e.Message);
}