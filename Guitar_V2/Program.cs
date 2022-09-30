public class Program {

    public static void Main(string[] args) {
        SearchGuitar();
    }

    private static void SearchGuitar() {
        Inventory inventory = new Inventory(initializeInventory());

        Guitar guitar = new Guitar("000004", 8254.52, Spec());
        Guitar searchResultGuitar = inventory.Search(guitar);

        if (searchResultGuitar != null) {
            PrintGuitarInformation(guitar);
        } else {
            Console.WriteLine("Sorry not Found!!!");
        }
    }

    private static void PrintGuitarInformation(Guitar guitar) {
        Console.WriteLine("*******************************");
        Console.WriteLine("Guitar serial-number: {0}", guitar.GetSerialNumber());
        Console.WriteLine("Guitar Price: {0}", guitar.GetPrice());

        Console.WriteLine("Guitar Builder name: {0} , Gender: {1}, Age: {2}",
         guitar.GetGuitarSpec().GetBuilder().GetBuilderName(),
         guitar.GetGuitarSpec().GetBuilder().GetGender(),
         guitar.GetGuitarSpec().GetBuilder().GetAge());

        Console.WriteLine("Guitar Model: {0}, Year: {1}",
         guitar.GetGuitarSpec().GetModel().GetName(),
         guitar.GetGuitarSpec().GetModel().GetYear());

        Console.WriteLine("Guitar Wood: {0}, ManufacturerName: {1}",
         guitar.GetGuitarSpec().GetWood().GetWoodName(),
         guitar.GetGuitarSpec().GetWood().GetManufacturerName());
        Console.WriteLine("*******************************");
    }

    private static Guitar[] initializeInventory() {
        Guitar[] guitars = { new Guitar("000001", 5000.52, Spec()),
        new Guitar("000002", 7412.52, Spec()),
        new Guitar("000003", 3917.52, Spec()),
        new Guitar("000004", 8254.52, Spec()),
        new Guitar("000005", 1234.52, Spec())};

        return guitars;
    }

    private static Wood Wood() {
        return new Wood("Alder", "kittinun Chobtham");
    }

    private static Type Model() {
        return new Type("Model s", 2022);
    }

    private static Builder Builder() {
        return new Builder("NhongZa", "Male", 47);
    }

    private static GuitarSpec Spec() {
        return new GuitarSpec(Program.Builder(), Program.Model(), Program.Wood());
    }

}