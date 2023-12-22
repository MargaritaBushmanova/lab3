using System.Text.Json;

namespace SerializeToFile
{
    class Program
    {
        static void Main()
        {
            Catalog myCatalog = new Catalog();
            Catalog.DisplayHelp();

            while (true)
            {
                string request = myCatalog.getRequest();
                Console.Write(request);
                string response = Console.ReadLine().ToLower();
                if (response == "quit")
                    break;
                Console.Write(myCatalog.setResponse(response));
            }
        }
    }
}
