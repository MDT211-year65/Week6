public class Inventory {
    private Guitar[] guitars;
    private Mendolin[] mendolins;

    public Inventory(Guitar[] guitars) {
        this.guitars = guitars;
    }

    public Inventory(Mendolin[] mendolins) {
        this.mendolins = mendolins;
    }

    public Guitar GetGuitar(string serialNumber) {
        foreach(Guitar guitar in guitars) {
            if (guitar.GetSerialNumber().Equals(serialNumber)) {
                return guitar;
            }
        }

        return null;
    }

     public Guitar GetGuitar(double price) {
        foreach(Guitar guitar in guitars) {
            if (guitar.GetPrice().Equals(price)) {
                return guitar;
            }
        }

        return null;
    } 

      public Mendolin GetMendolin(string serialNumber) {
        foreach(Mendolin mendolin in mendolins) {
            if (mendolin.GetSerialNumber().Equals(serialNumber)) {
                return mendolin;
            }
        }

        return null;
    }

     public Mendolin GetMendolin(double price) {
        foreach(Mendolin mendolin in mendolins) {
            if (mendolin.GetPrice().Equals(price)) {
                return mendolin;
            }
        }

        return null;
    } 

    public Guitar Search(Guitar searchGuitar) {
        foreach(Guitar guitar in guitars) { 
            string serialNumber = searchGuitar.GetSerialNumber();
            double price = searchGuitar.GetPrice();

            if (guitar.GetSerialNumber().Equals(serialNumber) && 
                guitar.GetPrice().Equals(price)) {
                    return guitar;
            }

        }

        return null;
    }

    public Mendolin Search(Mendolin searchMendolin) {
        foreach(Mendolin mendolin in mendolins) { 
            string serialNumber = searchMendolin.GetSerialNumber();
            double price = searchMendolin.GetPrice();

            if (mendolin.GetSerialNumber().Equals(serialNumber) && 
                mendolin.GetPrice().Equals(price)) {
                    return mendolin;
            }

        }

        return null;
    }

}