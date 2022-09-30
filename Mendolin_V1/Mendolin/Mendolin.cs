public class Mendolin {
    private string serialNumber;
    private double price;
    private MendolinSpec spec;

    public Mendolin(string serialNumber,
     double price,
     MendolinSpec spec) {
        this.serialNumber = serialNumber;
        this.price = price;
        this.spec = spec;
    }

    public string GetSerialNumber() {
        return this.serialNumber;
    }

    public double GetPrice() {
        return this.price;
    }

    public void SetPrice(double newPrice) {
        this.price = newPrice;
    }

    public MendolinSpec GetMendolinSpec() {
        return this.spec;
    }

}