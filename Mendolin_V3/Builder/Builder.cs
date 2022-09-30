public class Builder {
    private string name;
    private string gender;
    private int age;

    public Builder(string name, 
                   string gender, 
                   int age) {
        this.name = name;
        this.gender = gender;
        this.age = age;
    }

    public string GetBuilderName() {
        return this.name;
    }

    public string GetGender() {
       return  this.gender;
    }

    public int GetAge() {
        return this.age;
    }
    
}