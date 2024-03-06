class Circle{
    private double radius;

    public Circles(string colour, double radius1) : base(colour){
        radius = radius1;
    }
    public override double GetArea(){
        return radius * radius *Math.PI;
    }
}