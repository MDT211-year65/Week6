public class Mendolin: Instrument {
    private MendolinSpec spec;

    public Mendolin(string serialNumber,
     double price,
     MendolinSpec spec): base(serialNumber, price) {
        this.spec = spec;
    }

    public MendolinSpec GetMendolinSpec() {
        return this.spec;
    }

}