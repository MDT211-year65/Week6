public class Instrument {
    private string serialNumber;
    private double price;

    public Instrument(string serialNumber, 
    double price) {
        this.serialNumber = serialNumber;
        this.price = price;
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

}