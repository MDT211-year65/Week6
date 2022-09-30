public class Type {
    private string name;
    private int year;

    public Type(string name,
                int year) {
        this.name = name;
        this.year = year;
    }

    public string GetName() {
        return this.name;
    }

    public int GetYear() {
        return this.year;
    }
    
}