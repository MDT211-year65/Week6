public class MendolinSpec {
    private Builder builder;
    private Type model;
    private Wood wood;

    public MendolinSpec(Builder builder,
     Type model,
     Wood wood) {
        this.builder = builder;
        this.model = model; 
        this.wood = wood;
     }

    public Builder GetBuilder() {
        return this.builder;
    }

    public Type GetModel() {
        return this.model;
    }

    public Wood GetWood() {
        return this.wood;
    }

}