public class Program {

    public static void Main(string[] args) {
        SearchGuitar();
        searchMendolin();
    }

    private static void SearchGuitar() {
        Inventory inventory = new Inventory(initializeGuitarsInventory());

        Guitar guitar = new Guitar("000004", 8254.52, Spec());
        Guitar searchResultGuitar = inventory.Search(guitar);

        if (searchResultGuitar != null) {
            PrintGuitarInformation(guitar);
        } else {
            Console.WriteLine("Sorry Guitar not Found!!!");
        }
    }

    private static void searchMendolin() {
        Inventory inventory = new Inventory(initializeMendolinsInventory());

        Mendolin mendolin = new Mendolin("000001", 9000.52, Spec());
        Mendolin searchResultMendolin = inventory.Search(mendolin);

        if (searchResultMendolin != null) {
            PrintMendolinsInformation(mendolin);
        } else {
            Console.WriteLine("Sorry Mendolin not Found!!!");
        }
    }

    private static void PrintGuitarInformation(Guitar guitar) {
        Console.WriteLine("*******************************");
        Console.WriteLine("Guitar serial-number: {0}", guitar.GetSerialNumber());
        Console.WriteLine("Guitar Price: {0}", guitar.GetPrice());

        Console.WriteLine("Guitar Builder name: {0} , Gender: {1}, Age: {2}",
         guitar.GetSpec().GetBuilder().GetBuilderName(),
         guitar.GetSpec().GetBuilder().GetGender(),
         guitar.GetSpec().GetBuilder().GetAge());

        Console.WriteLine("Guitar Model: {0}, Year: {1}",
         guitar.GetSpec().GetModel().GetName(),
         guitar.GetSpec().GetModel().GetYear());

        Console.WriteLine("Guitar Wood: {0}, ManufacturerName: {1}",
         guitar.GetSpec().GetWood().GetWoodName(),
         guitar.GetSpec().GetWood().GetManufacturerName());
        Console.WriteLine("*******************************");
    }

     private static void PrintMendolinsInformation(Mendolin mendolin) {
        Console.WriteLine("*******************************");
        Console.WriteLine("Mendolin serial-number: {0}", mendolin.GetSerialNumber());
        Console.WriteLine("Mendolin Price: {0}", mendolin.GetPrice());

        Console.WriteLine("Mendolin Builder name: {0} , Gender: {1}, Age: {2}",
         mendolin.GetSpec().GetBuilder().GetBuilderName(),
         mendolin.GetSpec().GetBuilder().GetGender(),
         mendolin.GetSpec().GetBuilder().GetAge());

        Console.WriteLine("Mendolin Model: {0}, Year: {1}",
         mendolin.GetSpec().GetModel().GetName(),
         mendolin.GetSpec().GetModel().GetYear());

        Console.WriteLine("Mendolin Wood: {0}, ManufacturerName: {1}",
         mendolin.GetSpec().GetWood().GetWoodName(),
         mendolin.GetSpec().GetWood().GetManufacturerName());
        Console.WriteLine("*******************************");
    }

    private static Guitar[] initializeGuitarsInventory() {
        Guitar[] guitars = { new Guitar("000001", 5000.52, Spec()),
        new Guitar("000002", 7412.52, Spec()),
        new Guitar("000003", 3917.52, Spec()),
        new Guitar("000004", 8254.52, Spec()),
        new Guitar("000005", 1234.52, Spec())};

        return guitars;
    }

    private static Mendolin[] initializeMendolinsInventory() {
        Mendolin[] mendolins = { new Mendolin("000001", 9000.52, Spec()),
        new Mendolin("000002", 9412.52, Spec()),
        new Mendolin("000003", 7917.52, Spec()),
        new Mendolin("000004", 8254.52, Spec()),
        new Mendolin("000005", 1234.52, Spec())};

        return mendolins;
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

    private static InstrumentSpec Spec() {
        return new InstrumentSpec(Program.Builder(), Program.Model(), Program.Wood());
    }

}