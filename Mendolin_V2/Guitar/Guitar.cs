public class Guitar: Instrument {
    private GuitarSpec spec;

    public Guitar(string serialNumber,
     double price,
     GuitarSpec spec): base(serialNumber, price) {
        this.spec = spec;
    }

    public GuitarSpec GetGuitarSpec() {
        return this.spec;
    }

}