public class Wood {
    private string name;
    private string manufacturerName;

    public Wood(string name, 
                string manufacturerName) {
        this.name = name;
        this.manufacturerName = manufacturerName;
    }

    public string GetWoodName() {
        return this.name;
    }

    public string GetManufacturerName() {
        return this.manufacturerName;
    }
}