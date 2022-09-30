public class Instrument {
    private string serialNumber;
    private double price;
    private InstrumentSpec spec;

    public Instrument(string serialNumber, 
    double price,
    InstrumentSpec spec) {
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

    public InstrumentSpec GetSpec() {
        return this.spec;
    }

}